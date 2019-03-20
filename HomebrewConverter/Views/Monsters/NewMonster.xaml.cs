using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomebrewConverter.Views.Monsters
{
    /// <summary>
    /// Interaction logic for NewMonster.xaml
    /// </summary>
    public partial class NewMonster : UserControl
    {
        public NewMonster()
        {
            InitializeComponent();
        }
        
        public CreateNew()
        {
            InitializeComponent();
            DataContext = _monster;
            PopulateSkillsBox(Skill1)
                .PopulateSkillsBox(Skill2)
                .PopulateSkillsBox(Skill3)
                .PopulateSkillsBox(Skill4);
        }

        private string WithSign(int i)
        {
            var str = "";
            if (i >= 0)
                str = "+" + i;
            else
                str = i.ToString();
            return str;
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append($"Title: {_monster.Title}\n");
            sb.Append(
                $"Subtitle: {_monster.SubtitleSize} {_monster.SubtitleType.ToLower()}, {_monster.SubtitleAlignment}\n");

            sb.Append($"Armor Class: {_monster.ArmorClass} ({_monster.ArmorType})\n");
            sb.Append($"Hit Points: {_monster.HitPoints}\n");
            sb.Append($"Speed: {_monster.Speed}ft. ");
            if (_monster.Climb > 0)
            {
                sb.Append($"Climb: {_monster.Climb}ft. ");
            }
            if (_monster.Fly > 0)
            {
                sb.Append($"Fly: {_monster.Fly}ft.");
            }
            sb.Append("\n");

            sb.Append(
                $"Stats: " +
                $"STR: {_monster.Str} ({WithSign(_monster.StrMod)}) " +
                $"DEX: {_monster.Dex} ({WithSign(_monster.DexMod)}) " +
                $"CON: {_monster.Con} ({WithSign(_monster.ConMod)}) " +
                $"INT: {_monster.Int} ({WithSign(_monster.IntMod)}) " +
                $"WIS: {_monster.Wis} ({WithSign(_monster.WisMod)}) " +
                $"CHA: {_monster.Cha} ({WithSign(_monster.ChaMod)})\n");

            sb.Append($"Saving Throws: \n");


            PrintedValues.Text = sb.ToString();
        }

        private void TextBoxTitle_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && textBox != null && !textBox.IsReadOnly)
            {
                (textBox).SelectAll();
            }
        }

        private void ComboBox_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;

            if (e.KeyboardDevice.IsKeyDown(Key.Tab) && comboBox != null)
            {
                (comboBox).IsDropDownOpen = true;
            }
        }

        private CreateNew PopulateSkillsBox(ComboBox skillBox)
        {
            skillBox.ItemsSource = new List<string>
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
            return this;
        }
    }
}
