using System.ComponentModel;
using System.Runtime.CompilerServices;
using HomebrewConverter.Annotations;

namespace HomebrewConverter.Model
{
    class Monster : INotifyPropertyChanged
    {
        #region Properties

        public Monster()
        {

        }


        public Monster(string title, string monsterType)
        {
            _title = title;
            _monsterType = monsterType;
        }


        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value) return;

                _title = value;
                OnPropertyChanged();
            }
        }

        private string _monsterType;
        public string MonsterType
        {
            get => _monsterType;
            set
            {
                if (_monsterType == value)
                {
                    return;
                }

                _monsterType = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}