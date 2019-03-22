using System.ComponentModel;
using System.Runtime.CompilerServices;
using HomebrewConverter.Annotations;

namespace HomebrewConverter.Model
{
    class Monster : NotifyPropertyChangedBase
    {
        #region Construction

        public Monster()
        {

        }

        public Monster(string monsterTitle, string monsterSize, string monsterType, string monsterAlignment, int monsterArmorClass, string monsterArmorType, int monsterHitPoints, int monsterSpeed, int monsterClimbSpeed, int monsterFlySpeed, int monsterCharisma, int monsterWisdom, int monsterIntelligence, int monsterConstitution, int monsterDexterity, int monsterStrength)
        {
            _monsterTitle = monsterTitle;
            _monsterSize = monsterSize;
            _monsterType = monsterType;
            _monsterAlignment = monsterAlignment;
            _monsterArmorClass = monsterArmorClass;
            _monsterArmorType = monsterArmorType;
            _monsterHitPoints = monsterHitPoints;
            _monsterSpeed = monsterSpeed;
            _monsterClimbSpeed = monsterClimbSpeed;
            _monsterFlySpeed = monsterFlySpeed;
            _monsterCharisma = monsterCharisma;
            _monsterWisdom = monsterWisdom;
            _monsterIntelligence = monsterIntelligence;
            _monsterConstitution = monsterConstitution;
            _monsterDexterity = monsterDexterity;
            _monsterStrength = monsterStrength;
        }

        #endregion


        #region Property Initialization

        private string _monsterTitle;
        private string _monsterSize;
        private string _monsterType;
        private string _monsterAlignment;
        private int _monsterArmorClass;
        private string _monsterArmorType;
        private int _monsterHitPoints;
        private int _monsterSpeed;
        private int _monsterClimbSpeed;
        private int _monsterFlySpeed;
        private int _monsterCharisma;
        private int _monsterWisdom;
        private int _monsterIntelligence;
        private int _monsterConstitution;
        private int _monsterDexterity;
        private int _monsterStrength;


        #endregion


        #region Property Implementations

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

        public string MonsterSize
        {
            get => _monsterSize;
            set
            {
                if (_monsterSize == value) return;
                _monsterSize = value;
                OnPropertyChanged();
            }
        }
        
        public string MonsterType
        {
            get => _monsterType;
            set
            {
                if (_monsterType == value) return;
                _monsterType = value;
                OnPropertyChanged();
            }
        }

        public string MonsterAlignment
        {
            get => _monsterAlignment;
            set
            {
                if (_monsterAlignment == value) return;
                _monsterAlignment = value;
                OnPropertyChanged();
            }
        }

        public int MonsterArmorClass
        {
            get => _monsterArmorClass;
            set
            {
                if (value == _monsterArmorClass) return;
                _monsterArmorClass = value;
                OnPropertyChanged();
            }
        }

        public string MonsterArmorType
        {
            get => _monsterArmorType;
            set
            {
                if (value == _monsterArmorType) return;
                _monsterArmorType = value;
                OnPropertyChanged();
            }
        }

        public int MonsterHitPoints
        {
            get => _monsterHitPoints;
            set
            {
                if (value == _monsterHitPoints) return;
                _monsterHitPoints = value;
                OnPropertyChanged();
            }
        }

        public int MonsterSpeed
        {
            get => _monsterSpeed;
            set
            {
                if (value == _monsterSpeed) return;
                _monsterSpeed = value;
                OnPropertyChanged();
            }
        }

        public int MonsterClimbSpeed
        {
            get => _monsterClimbSpeed;
            set
            {
                if (value == _monsterClimbSpeed) return;
                _monsterClimbSpeed = value;
                OnPropertyChanged();
            }
        }

        public int MonsterFlySpeed
        {
            get => _monsterFlySpeed;
            set
            {
                if (value == _monsterFlySpeed) return;
                _monsterFlySpeed = value;
                OnPropertyChanged();
            }
        }

        public int MonsterStrength
        {
            get => _monsterStrength;
            set
            {
                if (value == _monsterStrength) return;
                _monsterStrength = value;
                OnPropertyChanged();
            }
        }

        public int MonsterDexterity
        {
            get => _monsterDexterity;
            set
            {
                if (value == _monsterDexterity) return;
                _monsterDexterity = value;
                OnPropertyChanged();
            }
        }

        public int MonsterConstitution
        {
            get => _monsterConstitution;
            set
            {
                if (value == _monsterConstitution) return;
                _monsterConstitution = value;
                OnPropertyChanged();
            }
        }

        public int MonsterIntelligence
        {
            get => _monsterIntelligence;
            set
            {
                if (value == _monsterIntelligence) return;
                _monsterIntelligence = value;
                OnPropertyChanged();
            }
        }

        public int MonsterWisdom
        {
            get => _monsterWisdom;
            set
            {
                if (value == _monsterWisdom) return;
                _monsterWisdom = value;
                OnPropertyChanged();
            }
        }

        public int MonsterCharisma
        {
            get => _monsterCharisma;
            set
            {
                if (value == _monsterCharisma) return;
                _monsterCharisma = value;
                OnPropertyChanged();
            }
        }

        #endregion


        #region Validators

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(MonsterTitle)
                   && !string.IsNullOrWhiteSpace(MonsterSize)
                   && !string.IsNullOrWhiteSpace(MonsterType)
                   && !string.IsNullOrWhiteSpace(MonsterAlignment)
                   && !string.IsNullOrWhiteSpace(MonsterArmorClass.ToString())
                   && !string.IsNullOrWhiteSpace(MonsterArmorType);
        }

        #endregion

        // ======================== EQUALS OPERATOR ====================
        #region Equals

        protected bool Equals(Monster other)
        {
            return string.Equals(_monsterTitle, other._monsterTitle) && string.Equals(_monsterSize, other._monsterSize) && string.Equals(_monsterType, other._monsterType) && string.Equals(_monsterAlignment, other._monsterAlignment);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Monster) obj);
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

    }
}
