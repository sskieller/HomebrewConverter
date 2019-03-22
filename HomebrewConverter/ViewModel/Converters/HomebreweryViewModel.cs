using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.SqlServer.Server;

namespace HomebrewConverter.ViewModel.Converters
{
    internal class HomebreweryViewModel : ViewModelBase
    {
        public HomebreweryViewModel()
        {
            FormatText = new RelayCommand(_ => FormatTextExecute(), _ => true);
            NonFormattedText = "";

        }

        public ICommand FormatText { get; set; }

        private void FormatTextExecute()
        {
            Debug.WriteLine("I converted!");
            var lines = NonFormattedText.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            ConvertToFormat(lines);
        }

        private string _nonFormattedText;

        public string NonFormattedText
        {
            get => _nonFormattedText;
            set
            {
                if (_nonFormattedText == value)
                    return;

                _nonFormattedText = value;
                OnPropertyChanged();
            }
        }

        private string _formattedText;

        public string FormattedText
        {
            get => _formattedText;
            set
            {
                if (_formattedText == value)
                    return;

                _formattedText = value;
                OnPropertyChanged();
            }
        }

        private bool _formatToWide;

        public bool FormatToWide
        {
            get => _formatToWide;
            set
            {
                if (_formatToWide == value)
                    return;

                _formatToWide = value;
                OnPropertyChanged();
            }
        }

        private void ConvertToFormat(string[] lines)
        {
            var sb = new StringBuilder();

            if (FormatToWide)
            {
                sb.Append("___\n");
            }

            sb.Append("___\n");

            // ======================= MonsterTitle and subtitle =======================
            sb.Append($"> ## {lines[0]}\n");
            sb.Append($">*{lines[1]}*\n");

            sb.Append($"> ___\n");

            // ======================= AC, HP, Speed =======================
            var splitString = lines[3].Split(new[] { "Armor Class" }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append($"> - **Armor Class** {splitString[0]}\n");
            splitString = lines[4].Split(new[] { "Hit Points" }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append($"> - **Hit Points** {splitString[0]}\n");
            splitString = lines[5].Split(new[] { "Speed" }, StringSplitOptions.RemoveEmptyEntries);
            sb.Append($"> - **Speed** {splitString[0]}\n");

            sb.Append($"> ___\n");

            // ======================= STR; DEX; CON; INT; WIS; CHA; =======================
            sb.Append(">|STR|DEX|CON|INT|WIS|CHA|\n");
            sb.Append(">|:---:|:---:|:---:|:---:|:---:|:---:|\n");
            sb.Append($">|{lines[8]}|{lines[10]}|{lines[12]}|{lines[14]}|{lines[16]}|{lines[18]}|\n");

            sb.Append($"> ___\n");

            // ======================= Condition etc Stats =======================
            // TODO: Fix it so only title is bold
            var values = ExtractStats(lines, _knownStats, true);
            foreach (var t in values)
            {
                sb.Append($"{t}\n");
                sb.Append(">\n");
            }

            sb.Append($"> ___\n");

            // ======================= Extra states =======================
            values = ExtractLines(lines, "Challenge", "Actions");
            values.RemoveAt(0);

            foreach (var value in values.Where(x => !string.IsNullOrWhiteSpace(x)))
            {
                // Split according to dot
                var words = value.Split('.');
                sb.Append($"> - ***{words.First()}.*** ");

                for (var i = 1; i < words.Length - 1; i++)
                {
                    sb.Append($"{words[i]}.");
                }
                sb.Append("\n");
            }

            // ======================= Spells etc. =======================
            values = ExtractStats(lines, _spellcasting, false);
            if (values.Any())
            {
                var enumerable = values.ToList();

                var words = enumerable.First().Split('.');

                sb.Append($"> ***{words.First()}.***");
                for (int i = 1; i < words.Length; i++)
                {
                    sb.Append($"{words[i]}.");
                }

                sb.Append("\n>\n");


                for (var i = 1; i < enumerable.Count(); i++)
                {
                    words = enumerable[i].Split(':');

                    sb.Append($"> {words.First()}: ");
                    for (int j = 1; j < words.Length; j++)
                    {
                        sb.Append($"*{words[j]}*");
                    }

                    sb.Append("\n>\n");
                }
            }

            values = ExtractLines(lines, "Actions", "Legendary Actions");
            sb.Append($"> ### {values.First()}\n");
            values.Remove("Actions");

            // ======================= Actions =======================
            foreach (var value in values.Where(x => !string.IsNullOrWhiteSpace(x)))
            {
                var title = "";
                var charLocation = value.IndexOf(".", StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    title = value.Substring(0, charLocation + 1);
                }
                sb.Append($"> ***{title}***");

                var actionsDescription = value.Replace(title, "");
                sb.Append($"{actionsDescription}");

                sb.Append("\n>\n");
            }

            // ======================= Legendary Actions =======================
            values = ExtractLines(lines, "Legendary Actions", null);
            if (values.Any())
            {
                sb.Append($"> ### {values.First()}\n");
                values.Remove("Legendary Actions");

                foreach (var value in values)
                {
                    sb.Append($"> {value}\n");
                    sb.Append(">\n");
                }
            }

            sb.Append("\n");


            FormattedText = sb.ToString();
        }

        private static List<string> ExtractStats(IReadOnlyList<string> lines, IReadOnlyCollection<string> knownStats, bool stats)
        {
            var matchedValues = new List<string>();
            for (var i = 10; i < lines.Count; i++)
            {
                var matchedKeyword = knownStats.FirstOrDefault(x => lines[i].StartsWith(x));

                //check if contains keyword
                if (matchedKeyword == null)
                {
                    continue;
                }

                if (stats)
                {
                    var replace = lines[i].Replace(matchedKeyword, "");
                    matchedValues.Add($"> **{matchedKeyword}** {replace}");
                    Debug.WriteLine(matchedValues);
                }
                else
                {
                    matchedValues.Add(lines[i]);
                }

            }
            return matchedValues;
        }

        private static List<string> ExtractLines(IEnumerable<string> lines, string startWord, string endWord)
        {
            List<string> extractedValues;
            if (endWord != null)
            {
                extractedValues = lines.SkipWhile(x => !x.StartsWith(startWord))
                    .TakeWhile(x => !x.StartsWith(endWord)).Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToList();
            }
            else
            {
                extractedValues = lines.SkipWhile(x => !x.StartsWith(startWord))
                    .Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            }

            return extractedValues;
        }

        private readonly List<string> _knownStats = new List<string>()
        {
            "Saving Throws",
            "Skills",
            "Damage Resistances",
            "Damage Immunities",
            "Condition Immunities",
            "Senses",
            "Languages",
            "Challenge",
        };

        private readonly List<string> _resistance = new List<string>()
        {
            "Legendary Resistance",
            "Magic Resistance",
        };

        private readonly List<string> _spellcasting = new List<string>()
        {
            "Spellcasting",
            "Cantrips",
            "1st level",
            "2nd level",
            "3rd level",
            "4th level",
            "5th level",
            "6th level",
            "7th level",
            "8th level",
            "9th level",
            "*",
        };
    }
}
