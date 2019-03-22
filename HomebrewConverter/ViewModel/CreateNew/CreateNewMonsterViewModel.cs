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
        private Monster _tempMonster = new Monster();
        private ObservableCollection<Monster> _monsters;

        public ICommand AddMonster { get; set; }
        public List<string> MonsterSizeList => Categories.MonsterSizeList;
        public List<string> MonsterTypeList => Categories.MonsterTypeList;
        public List<string> MonsterAlignmentList => Categories.MonsterAlignmentList;


        #region Construction

        public CreateNewMonsterViewModel()
        {
            // Relay Commands
            AddMonster = new RelayCommand(_ => AddMonsterExecute(), _ => TempMonster.IsValid());

            // Monsters saved TODO: Add to In-Memory SQL Database
            Monsters = new ObservableCollection<Monster>();

            // Adding test data
            var monsters = new List<string> { "Acolyte", "Dragon", "Kraken" };
            foreach (var monster in monsters)
            {
                Monsters.Add(new Monster { MonsterTitle = monster, MonsterType = "Nobody" });
            }
        }


        #endregion

        #region Properties

        
        public ObservableCollection<Monster> Monsters
        {
            get => _monsters;
            set
            {
                _monsters = value;
                OnPropertyChanged();
            }
        }

        public Monster TempMonster
        {
            get => _tempMonster;
            private set
            {
                _tempMonster = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Commands

        private void AddMonsterExecute()
        {
            var foundMonster = Monsters.FirstOrDefault(x => TempMonster.Equals(x));
            if (foundMonster != null)
            {
                Debug.WriteLine("Monster already exists");
                return;
            }
            Monsters?.Add(TempMonster);

            TempMonster = new Monster();

            Debug.WriteLine($"Monster added.\n" +
                            $"MonsterTitle: {TempMonster.MonsterTitle}\n" +
                            $"Size: {TempMonster.MonsterSize}\n" +
                            $"Type: {TempMonster.MonsterType}\n" +
                            $"Alignment: {TempMonster.MonsterAlignment}");
        }


        #endregion

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
            sb.Append($"MonsterTitle: {TempMonster.MonsterTitle}\n");
            sb.Append(
                $"Subtitle: {TempMonster.MonsterType}\n");

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