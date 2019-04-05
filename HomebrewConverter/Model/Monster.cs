namespace HomebrewConverter.Model
{
    internal class Monster : NotifyPropertyChangedBase
    {
        #region Construction

        public Monster()
        {

        }

        #endregion


        #region Property Initialization

        private string _monsterTitle;
        private string _monsterSize;
        private string _monsterType;
        private string _monsterAlignment;
        private string _monsterArmorClass;
        private string _monsterArmorType;
        private string _monsterHitPoints;
        private string _monsterSpeed;
        private string _monsterClimbSpeed;
        private string _monsterFlySpeed;

        // Monster stats
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

        // Monster saving throws
        private string _monsterSavingThrowStrength;
        private string _monsterSavingThrowDexterity;
        private string _monsterSavingThrowConstitution;
        private string _monsterSavingThrowIntelligence;
        private string _monsterSavingThrowCharisma;
        private string _monsterSavingThrowWisdom;

        // Skills
        private string _monsterSkill1;
        private string _monsterSkill2;
        private string _monsterSkill3;
        private string _monsterSkill4;

        #endregion

        #region Commands



        #endregion

        #region Property Implementations

        #region Monster main stats



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

        public string MonsterArmorClass
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

        public string MonsterHitPoints
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

        public string MonsterSpeed
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

        public string MonsterClimbSpeed
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

        public string MonsterFlySpeed
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

        #endregion

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

        #region Saving Throws


        public string MonsterSavingThrowStrength
        {
            get => _monsterSavingThrowStrength; set
            {
                if (value == _monsterSavingThrowStrength)
                {
                    return;
                }

                _monsterSavingThrowStrength = value.Trim();
                OnPropertyChanged();
            }
        }

        public string MonsterSavingThrowDexterity
        {
            get => _monsterSavingThrowDexterity;
            set
            {
                if (value == _monsterSavingThrowDexterity)
                {
                    return;
                }

                _monsterSavingThrowDexterity = value.Trim();
                OnPropertyChanged();
            }
        }

        public string MonsterSavingThrowConstitution
        {
            get => _monsterSavingThrowConstitution;
            set
            {
                if (value == _monsterSavingThrowConstitution)
                {
                    return;
                }

                _monsterSavingThrowConstitution = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSavingThrowIntelligence
        {
            get => _monsterSavingThrowIntelligence;
            set
            {
                if (value == _monsterSavingThrowIntelligence)
                {
                    return;
                }

                _monsterSavingThrowIntelligence = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSavingThrowWisdom
        {
            get => _monsterSavingThrowWisdom;
            set
            {
                if (value == _monsterSavingThrowWisdom)
                {
                    return;
                }

                _monsterSavingThrowWisdom = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSavingThrowCharisma
        {
            get => _monsterSavingThrowCharisma;
            set
            {
                if (value == _monsterSavingThrowCharisma)
                {
                    return;
                }

                _monsterSavingThrowCharisma = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Skills

        public string MonsterSkill1
        {
            get => _monsterSkill1;
            set
            {
                if (value == _monsterSkill1)
                {
                    return;
                }

                _monsterSkill1 = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSkill2
        {
            get => _monsterSkill2;
            set
            {
                if (value == _monsterSkill2)
                {
                    return;
                }

                _monsterSkill2 = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSkill3
        {
            get => _monsterSkill3;
            set
            {
                if (value == _monsterSkill3)
                {
                    return;
                }

                _monsterSkill3 = value;
                OnPropertyChanged();
            }
        }

        public string MonsterSkill4
        {
            get => _monsterSkill4;
            set
            {
                if (value == _monsterSkill4)
                {
                    return;
                }

                _monsterSkill4 = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #endregion


        #region Validators

        // Makes sure the required regions are filled
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(MonsterTitle)
                   && !string.IsNullOrWhiteSpace(MonsterSize)
                   && !string.IsNullOrWhiteSpace(MonsterType)
                   && !string.IsNullOrWhiteSpace(MonsterAlignment)
                   && !string.IsNullOrWhiteSpace(MonsterArmorClass) && int.Parse(MonsterArmorClass) > 0
                   // MonsterArmorType
                   && !string.IsNullOrWhiteSpace(MonsterHitPoints) && int.Parse(MonsterHitPoints) > 0
                   && !string.IsNullOrWhiteSpace(MonsterSpeed) && int.Parse(MonsterSpeed) > 0
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

                    // MonsterSavingThrowStrength
                    // MonsterSavingThrowDexterity
                    // MonsterSavingThrowConstitution
                    // MonsterSavingThrowIntelligence
                    // MonsterSavingThrowWisdom
                    // MonsterSavingThrowCharisma

                    // MonsterSkill1
                    // MonsterSkill2
                    // MonsterSkill3
                    // MonsterSkill4
                    ;
        }

        #endregion



        // ======================== EQUALS OPERATOR ====================
        #region Equals

        protected bool Equals(Monster other)
        {
            return string.Equals(_monsterTitle, other._monsterTitle) && string.Equals(_monsterSize, other._monsterSize) && string.Equals(_monsterType, other._monsterType) && string.Equals(_monsterAlignment, other._monsterAlignment) && string.Equals(_monsterArmorClass, other._monsterArmorClass) && string.Equals(_monsterHitPoints, other._monsterHitPoints) && string.Equals(_monsterSpeed, other._monsterSpeed) && string.Equals(_monsterStrength, other._monsterStrength) && string.Equals(_monsterDexterity, other._monsterDexterity) && string.Equals(_monsterConstitution, other._monsterConstitution) && string.Equals(_monsterIntelligence, other._monsterIntelligence) && string.Equals(_monsterWisdom, other._monsterWisdom) && string.Equals(_monsterCharisma, other._monsterCharisma);
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

            return obj.GetType() == GetType() && Equals((Monster)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_monsterTitle != null ? _monsterTitle.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterSize != null ? _monsterSize.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterType != null ? _monsterType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterAlignment != null ? _monsterAlignment.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterArmorClass != null ? _monsterArmorClass.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterHitPoints != null ? _monsterHitPoints.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterSpeed != null ? _monsterSpeed.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterStrength != null ? _monsterStrength.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterDexterity != null ? _monsterDexterity.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterConstitution != null ? _monsterConstitution.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterIntelligence != null ? _monsterIntelligence.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterWisdom != null ? _monsterWisdom.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (_monsterCharisma != null ? _monsterCharisma.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion

    }
}