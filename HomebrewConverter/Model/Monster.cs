using System.ComponentModel;
using System.Runtime.CompilerServices;
using HomebrewConverter.Annotations;

namespace HomebrewConverter.Model
{
    class Monster : INotifyPropertyChanged
    {
        #region Equals

        protected bool Equals(Monster other)
        {
            return string.Equals(_monsterTitle, other._monsterTitle) &&
                   string.Equals(_monsterSize, other._monsterSize) &&
                   string.Equals(_monsterType, other._monsterType) &&
                   string.Equals(_monsterAlignment, other._monsterAlignment);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Monster)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_monsterTitle != null ? _monsterTitle.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterSize != null ? _monsterSize.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterType != null ? _monsterType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterAlignment != null ? _monsterAlignment.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion


        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(MonsterTitle)
                   && !string.IsNullOrWhiteSpace(MonsterSize)
                   && !string.IsNullOrWhiteSpace(MonsterType)
                   && !string.IsNullOrWhiteSpace(MonsterAlignment);
        }


        #region Properties

        public Monster()
        {

        }

        public Monster(string monsterTitle, string monsterSize, string monsterType, string monsterAlignment)
        {
            _monsterTitle = monsterTitle;
            _monsterSize = monsterSize;
            _monsterType = monsterType;
            _monsterAlignment = monsterAlignment;
        }


        private string _monsterTitle;
        public string MonsterTitle
        {
            get => _monsterTitle;
            set
            {
                if (_monsterTitle == value) return;

                _monsterTitle = value;
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


//private int CalculateModifierScore(int statValue)
//    {
//        // Algorithm: (i/2-5)=modifier
//    }


//    public int ArmorClass { get; set; }
//    public string ArmorType { get; set; }

//    public int HitPoints { get; set; }
//    public int Speed { get; set; }
//    public int Climb { get; set; }
//    public int Fly { get; set; }

//    public int Str { get; set; }    
//    public int Dex { get; set; }
//    public int Con { get; set; }
//    public int Int { get; set; }
//    public int Wis { get; set; }
//    public int Cha { get; set; }