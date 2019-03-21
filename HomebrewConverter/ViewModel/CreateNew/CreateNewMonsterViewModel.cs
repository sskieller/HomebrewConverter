using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using HomebrewConverter.Model;

namespace HomebrewConverter.ViewModel.CreateNew
{
    internal class CreateNewMonsterViewModel : ViewModelBase
    {
        #region Construction

        public CreateNewMonsterViewModel()
        {
            AddMonster = new RelayCommand(_ => AddMonsterExecute(), _ => true);

            Monsters = new ObservableCollection<Monster>
            {

            };

            var monsters = new List<string> { "Acolyte", "Dragon", "Kraken" };
            foreach (var monster in monsters)
            {
                Monsters.Add(new Monster { Title = monster, MonsterType = "Nobody" });
            }
        }

        public ICommand AddMonster { get; set; }


        #endregion


        #region Properties

        private ObservableCollection<Monster> _monsters;

        public ObservableCollection<Monster> Monsters
        {
            get => _monsters;
            set
            {
                _monsters = value;
                OnPropertyChanged();
            }
        }
            


        private string _monsterTitle;

        public string MonsterTitle
        {
            get => _monsterTitle;
            set
            {
                if (_monsterTitle == value)
                    return;

                _monsterTitle = value;
                OnPropertyChanged();
            }
        }


        #endregion


        

        #region Commands


        

        
        private void AddMonsterExecute()
        {
            Debug.WriteLine($"Monster added: {MonsterTitle}");
            Monsters?.Add(new Monster
            {
                Title = MonsterTitle,
                MonsterType = SelectedMonsterType,
                MonsterAlignment = SelectedAlignment,
                MonsterSize = SelectedMonsterSize,
            });
        }


        #endregion

        private string _selectedMonsterSize;
        public string SelectedMonsterSize
        {
            get => _selectedMonsterSize;
            set
            {
                if (_selectedMonsterSize == value)
                    return;

                _selectedMonsterSize = value;
                OnPropertyChanged();
            }
        }
        public List<string> MonsterSizeList = new List<string>()
        {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
        };

        private string _selectedMonsterType;

        public string SelectedMonsterType
        {
            get => _selectedMonsterType;
            set
            {
                if (_selectedMonsterType == value)
                    return;

                _selectedMonsterType = value;
                OnPropertyChanged();
            }
        }
        public List<string> MonsterTypeList = new List<string>()
        {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead",
        };


        private string _selectedAlignment;

        public string SelectedAlignment
        {
            get => _selectedAlignment;
            set
            {
                if (_selectedAlignment == value)
                    return;

                _selectedAlignment = value;
                OnPropertyChanged();
            }
        }
        public List<string> AlignmentList = new List<string>()
        {
            "Any",
            "Lawful Good",
            "Lawful Neutral",
            "Lawful Evil",
            "Neutral Good",
            "True Neutral",
            "Neutral Evil",
            "Chaotic Good",
            "Chaotic Neutral",
            "Chaotic Evil",
        };

        public List<string> SkillsList = new List<string>
        {
            "Acrobatics",
            "Animal Handling",
            "Arcana",
            "Athletics",
            "Deception",
            "History",
            "Insight",
            "Intimidation",
            "Investigation",
            "Medicine",
            "Nature",
            "Perception",
            "Performance",
            "Persuasion",
            "Religion",
            "Sleight of Hand",
            "Stealth",
            "Survival",
        };


        #region OldCode

        private string WithSign(int i)
        {
            var str = "";
            if (i >= 0)
                str = "+" + i;
            else
                str = i.ToString();
            return str;
        }

        private void ButtonBase_OnClick()
        {
            var sb = new StringBuilder();
            sb.Append($"Title: {MonsterTitle}\n");
            sb.Append(
                $"Subtitle: {SelectedMonsterSize} {SelectedMonsterType.ToLower()}, {SelectedAlignment}\n");

            //sb.Append($"Armor Class: {_monster.ArmorClass} ({_monster.ArmorType})\n");
            //sb.Append($"Hit Points: {_monster.HitPoints}\n");
            //sb.Append($"Speed: {_monster.Speed}ft. ");
            //if (_monster.Climb > 0)
            //{
            //    sb.Append($"Climb: {_monster.Climb}ft. ");
            //}
            //if (_monster.Fly > 0)
            //{
            //    sb.Append($"Fly: {_monster.Fly}ft.");
            //}
            //sb.Append("\n");

            //sb.Append(
            //    $"Stats: " +
            //    $"STR: {_monster.Str} ({WithSign(_monster.StrMod)}) " +
            //    $"DEX: {_monster.Dex} ({WithSign(_monster.DexMod)}) " +
            //    $"CON: {_monster.Con} ({WithSign(_monster.ConMod)}) " +
            //    $"INT: {_monster.Int} ({WithSign(_monster.IntMod)}) " +
            //    $"WIS: {_monster.Wis} ({WithSign(_monster.WisMod)}) " +
            //    $"CHA: {_monster.Cha} ({WithSign(_monster.ChaMod)})\n");

            //sb.Append($"Saving Throws: \n");


            Debug.WriteLine(sb.ToString());
        }

        #endregion
    }
}