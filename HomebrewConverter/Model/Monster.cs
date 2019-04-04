namespace HomebrewConverter.Model
{
    internal class Monster : NotifyPropertyChangedBase
    {
        #region Construction

        public Monster()
        {

        }
        
        public Monster(string monsterTitle, string monsterSize, string monsterType, string monsterAlignment, int monsterArmorClass, string monsterArmorType, int monsterHitPoints, int monsterSpeed, int monsterClimbSpeed, int monsterFlySpeed, string monsterStrength, string monsterDexterity, string monsterConstitution, string monsterIntelligence, string monsterWisdom, string monsterCharisma)
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
            _monsterStrength = monsterStrength;
            _monsterDexterity = monsterDexterity;
            _monsterConstitution = monsterConstitution;
            _monsterIntelligence = monsterIntelligence;
            _monsterWisdom = monsterWisdom;
            _monsterCharisma = monsterCharisma;
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
        private string _monsterStrength;
        private string _monsterDexterity;
        private string _monsterConstitution;
        private string _monsterIntelligence;
        private string _monsterWisdom;
        private string _monsterCharisma;


        // Used for notifying UI Elements, do not delete
        #pragma warning disable CS0169 // Warning for unused variables
        private int _monsterCharismaModifier;
        private int _monsterWisdomModifier;
        private int _monsterIntelligenceModifier;
        private int _monsterConstitutionModifier;
        private int _monsterDexterityModifier;
        private int _monsterStrengthModifier;
        #pragma warning restore CS0169

        #endregion

        #region Commands



        #endregion

        #region Property Implementations

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

        public string MonsterAlignment
        {
            get => _monsterAlignment;
            set
            {
                if (_monsterAlignment == value)
                {
                    return;
                }

                _monsterAlignment = value;
                OnPropertyChanged();
            }
        }

        public int MonsterArmorClass
        {
            get => _monsterArmorClass;
            set
            {
                if (value == _monsterArmorClass)
                {
                    return;
                }

                _monsterArmorClass = value;
                OnPropertyChanged();
            }
        }

        public string MonsterArmorType
        {
            get => _monsterArmorType;
            set
            {
                if (value == _monsterArmorType)
                {
                    return;
                }

                _monsterArmorType = value;
                OnPropertyChanged();
            }
        }

        public int MonsterHitPoints
        {
            get => _monsterHitPoints;
            set
            {
                if (value == _monsterHitPoints)
                {
                    return;
                }

                _monsterHitPoints = value;
                OnPropertyChanged();
            }
        }

        public int MonsterSpeed
        {
            get => _monsterSpeed;
            set
            {
                if (value == _monsterSpeed)
                {
                    return;
                }

                _monsterSpeed = value;
                OnPropertyChanged();
            }
        }

        public int MonsterClimbSpeed
        {
            get => _monsterClimbSpeed;
            set
            {
                if (value == _monsterClimbSpeed)
                {
                    return;
                }

                _monsterClimbSpeed = value;
                OnPropertyChanged();
            }
        }

        public int MonsterFlySpeed
        {
            get => _monsterFlySpeed;
            set
            {
                if (value == _monsterFlySpeed)
                {
                    return;
                }

                _monsterFlySpeed = value;
                OnPropertyChanged();
            }
        }

        #region Class stats and modifiers

        private static int GetModifer(int i)
        {
            return i / 2 - 5;
        }

        public string MonsterStrength
        {
            get => _monsterStrength;
            set
            {
                if (value == _monsterStrength)
                {
                    return;
                }

                _monsterStrength = value.Trim();
                OnPropertyChanged();
                OnPropertyChanged("MonsterStrengthModifier");
            }
        }

        public int MonsterStrengthModifier => GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterStrength) ? "10" : MonsterStrength));


        public string MonsterDexterity
        {
            get => _monsterDexterity;
            set
            {
                if (value == _monsterDexterity)
                {
                    return;
                }

                _monsterDexterity = value;
                OnPropertyChanged();
                OnPropertyChanged("MonsterDexterityModifier");
            }
        }

        public int MonsterDexterityModifier =>
            GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterDexterity) ? "10" : MonsterDexterity));


        public string MonsterConstitution
        {
            get => _monsterConstitution;
            set
            {
                if (value == _monsterConstitution)
                {
                    return;
                }

                _monsterConstitution = value;
                OnPropertyChanged();
                OnPropertyChanged("MonsterConstitutionModifier");
            }
        }

        public int MonsterConstitutionModifier =>
            GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterConstitution) ? "10" : MonsterConstitution));


        public string MonsterIntelligence
        {
            get => _monsterIntelligence;
            set
            {
                if (value == _monsterIntelligence)
                {
                    return;
                }

                _monsterIntelligence = value;
                OnPropertyChanged();
                OnPropertyChanged("MonsterIntelligenceModifier");
            }
        }

        public int MonsterIntelligenceModifier =>
            GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterIntelligence) ? "10" : MonsterIntelligence));


        public string MonsterWisdom
        {
            get => _monsterWisdom;
            set
            {
                if (value == _monsterWisdom)
                {
                    return;
                }

                _monsterWisdom = value;
                OnPropertyChanged();
                OnPropertyChanged("MonsterWisdomModifier");
            }
        }

        public int MonsterWisdomModifier =>
            GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterWisdom) ? "10" : MonsterWisdom));


        public string MonsterCharisma
        {
            get => _monsterCharisma;
            set
            {
                if (value == _monsterCharisma)
                {
                    return;
                }

                _monsterCharisma = value;
                OnPropertyChanged();
                OnPropertyChanged("MonsterCharismaModifier");
            }
        }

        public int MonsterCharismaModifier =>
            GetModifer(int.Parse(string.IsNullOrWhiteSpace(MonsterCharisma) ? "10" : MonsterCharisma));

        #endregion


        #endregion


        #region Validators

        // Makes sure the required regions are filled
        public bool IsValid()
        {
            return    !string.IsNullOrWhiteSpace(MonsterTitle)
                   && !string.IsNullOrWhiteSpace(MonsterSize)
                   && !string.IsNullOrWhiteSpace(MonsterType)
                   && !string.IsNullOrWhiteSpace(MonsterAlignment)
                   && !string.IsNullOrWhiteSpace(MonsterArmorClass.ToString()) && MonsterArmorClass > 0
                   // MonsterArmorType
                   && !string.IsNullOrWhiteSpace(MonsterHitPoints.ToString()) && MonsterHitPoints > 0
                   && !string.IsNullOrWhiteSpace(MonsterSpeed.ToString()) && MonsterSpeed > 0
                    // MonsterClimbSpeed
                    // MonsterFlySpeed
                   && !string.IsNullOrWhiteSpace(MonsterStrength)
                   && !string.IsNullOrWhiteSpace(MonsterDexterity)
                   && !string.IsNullOrWhiteSpace(MonsterConstitution)
                   && !string.IsNullOrWhiteSpace(MonsterIntelligence)
                   && !string.IsNullOrWhiteSpace(MonsterWisdom)
                   && !string.IsNullOrWhiteSpace(MonsterCharisma)
                    // MonsterStrengthModifier
                    // MonsterDexterityModifier
                    // MonsterConstitutionModifier
                    // MonsterIntelligenceModifier
                    // MonsterWisdomModifier
                    // MonsterCharismaModifier
                    ;
        }

        #endregion

        

        // ======================== EQUALS OPERATOR ====================
        #region Equals

        protected bool Equals(Monster other)
        {
            return string.Equals(_monsterTitle, other._monsterTitle) && string.Equals(_monsterSize, other._monsterSize) && string.Equals(_monsterType, other._monsterType) && string.Equals(_monsterAlignment, other._monsterAlignment) && _monsterArmorClass == other._monsterArmorClass && _monsterHitPoints == other._monsterHitPoints && _monsterSpeed == other._monsterSpeed;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

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
                hashCode = (hashCode * 397) ^ _monsterArmorClass;
                hashCode = (hashCode * 397) ^ _monsterHitPoints;
                hashCode = (hashCode * 397) ^ _monsterSpeed;
                return hashCode;
            }
        }

        #endregion

    }
}
