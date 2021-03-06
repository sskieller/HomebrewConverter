﻿using HomebrewConverter.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
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
        public ICommand GetModifier { get; set; }
        public List<string> MonsterSizeList => Categories.MonsterSizeList;
        public List<string> MonsterTypeList => Categories.MonsterTypeList;
        public List<string> MonsterAlignmentList => Categories.MonsterAlignmentList;
        public List<string> MonsterSkillsList => Categories.MonsterSkillsList;

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

            TempMonster = new Monster
            {
                MonsterSize = MonsterSizeList.FirstOrDefault(),
                MonsterType = MonsterTypeList.FirstOrDefault(),
                MonsterAlignment = MonsterAlignmentList.FirstOrDefault(),
                MonsterSkill1 = MonsterSkillsList.FirstOrDefault(),
            };

            Debug.WriteLine($"Monster added.\n" +
                            $"MonsterTitle: {TempMonster.MonsterTitle}\n" +
                            $"Size: {TempMonster.MonsterSize}\n" +
                            $"Type: {TempMonster.MonsterType}\n" +
                            $"Alignment: {TempMonster.MonsterAlignment}");
        }



        #endregion
    }
}