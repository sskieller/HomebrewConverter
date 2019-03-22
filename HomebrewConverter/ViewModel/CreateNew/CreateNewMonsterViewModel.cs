using HomebrewConverter.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HomebrewConverter.ViewModel.CreateNew
{
    internal class CreateNewMonsterViewModel : ViewModelBase
    {
        // Diagnose in XAML:
        //  {Binding Path=X, diag:PresentationTraceSources.TraceLevel=High}

        #region Construction

        public CreateNewMonsterViewModel()
        {
            AddMonster = new RelayCommand(_ => AddMonsterExecute(), _ => true);

            Monsters = new ObservableCollection<Monster>();

            Debug.WriteLine(MonsterSizeList.FirstOrDefault());

            var monsters = new List<string> { "Acolyte", "Dragon", "Kraken" };
            foreach (var monster in monsters)
            {
                Monsters.Add(new Monster { Title = monster, MonsterType = "Nobody" });
            }
        }

        public ICommand AddMonster { get; set; }


        #endregion


        //x:Name="PeopleComboBox"
        //DisplayMemberPath="Name"
        //SelectedValue="{Binding Path=SelectedEntity.PersonID}"
        //SelectedValuePath="ID"
        ///>

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
                {
                    return;
                }

                _monsterTitle = value;
                OnPropertyChanged();
            }
        }


        #endregion


        #region Commands

        private void AddMonsterExecute()
        {
            
            Monsters?.Add(new Monster
            {
                Title = MonsterTitle,
                MonsterSize = SelectedMonsterSize,
                MonsterType = SelectedMonsterType,
                MonsterAlignment = SelectedMonsterAlignment,
                
            });

            var temp = Monsters.LastOrDefault();
            Debug.WriteLine($"Monster added.\n" +
                            $"Title: {temp.Title}\n" +
                            $"Size: {temp.MonsterSize}\n" +
                            $"Type: {temp.MonsterType}\n" +
                            $"Alignment: {temp.MonsterAlignment}");

        }


        #endregion

        // TODO: Set default value in Combobox
        private string _selectedMonsterSize;
        public string SelectedMonsterSize
        {
            get => _selectedMonsterSize;
            set
            {
                if (_selectedMonsterSize == value)
                {
                    return;
                }

                _selectedMonsterSize = value;
                OnPropertyChanged();
            }
        }

        public List<string> MonsterSizeList { get; set; } = new List<string>
        {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
        };


        // TODO: IMPLEMENT!

        private string _selectedMonsterType;
        public string SelectedMonsterType
        {
            get => _selectedMonsterType;
            set
            {
                if (_selectedMonsterType == value)
                {
                    return;
                }

                _selectedMonsterType = value;
                OnPropertyChanged();
            }
        }
        public List<string> MonsterTypeList { get; set; } = new List<string>
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


        private string _selectedMonsterAlignment;

        public string SelectedMonsterAlignment
        {
            get => _selectedMonsterAlignment;
            set
            {
                if (_selectedMonsterAlignment == value)
                {
                    return;
                }

                _selectedMonsterAlignment = value;
                OnPropertyChanged();
            }
        }
        public List<string> MonsterAlignmentList { get; set; } = new List<string>
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
            {
                str = "+" + i;
            }
            else
            {
                str = i.ToString();
            }

            return str;
        }

        private void ButtonBase_OnClick()
        {
            var sb = new StringBuilder();
            sb.Append($"Title: {MonsterTitle}\n");
            sb.Append(
                $"Subtitle: {SelectedMonsterSize} {SelectedMonsterType.ToLower()}, {SelectedMonsterAlignment}\n");

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