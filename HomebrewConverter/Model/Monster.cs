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

        public Monster(string title, string monsterSize, string monsterType, string monsterAlignment)
        {
            _title = title;
            _monsterSize = monsterSize;
            _monsterType = monsterType;
            _monsterAlignment = monsterAlignment;
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

        private string _monsterSize;

        public string MonsterSize
        {
            get => _monsterSize;
            set
            {
                if (_monsterSize == value)
                {
                    return;
                }

                _monsterSize = value;
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

        private string _monsterAlignment;

        public string MonsterAlignment
        {
            get => _monsterAlignment;
            set
            {
                if (_monsterAlignment == value)
                    return;

                _monsterAlignment = value;
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