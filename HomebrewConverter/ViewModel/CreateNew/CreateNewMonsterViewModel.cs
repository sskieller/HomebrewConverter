using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using HomebrewConverter.Model;

namespace HomebrewConverter.ViewModel.CreateNew
{
    internal class CreateNewMonsterViewModel : ViewModelBase
    {
        #region Properties

        public ObservableCollection<Monster> Monsters { get; set; }
            = new ObservableCollection<Monster>();

        #endregion


        #region Construction

        public CreateNewMonsterViewModel()
        {
            AddMonster = new RelayCommand(_ => AddMonsterExecute(), _ => true);
            TextBoxKeyboardFocus = new RelayCommand( TextBoxKeyboardFocusExecute, _ => true);

            var monsters = new List<string> {"Acolyte", "Dragon", "Kraken"};
            foreach (var monster in monsters)
            {
                Monsters.Add(new Monster{Title = monster, MonsterType = "Nobody"});
            }
        }

        #endregion

        #region Commands


        public ICommand AddMonster { get; set; }
        public ICommand TextBoxKeyboardFocus { get; set; }

        public string MonsterTitle { get; set; }
        private void AddMonsterExecute()
        {
            Monsters?.Add(new Monster{Title = MonsterTitle, MonsterType = "New Nobody"});
            
        }

        private TextBox _textBox { get; set; }
        private void TextBoxKeyboardFocusExecute(object o)
        {
            var x = o as TextBox;
            
        }

        #endregion
    }
}
