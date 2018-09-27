using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class StatsViewModel : ViewModelBase
    {
        private double _power;
        private double _stamina;
        private double _agility;
        private double _altPower;
        private double _altStamina;
        private double _altAgility;
        private double _damageBonus;
        private double _healthBonus;
        private double _speedBonus;
        private double _criticalChance;
        private double _criticalDamage;
        private double _damageEnrage;
        private double _dualStrike;
        private double _empowerChance;
        private double _quadStrike;
        private double _evadeChance;
        private double _blockChance;
        private double _lifeSteal;
        private double _deflectChance;
        private double _absorbChance;
        private double _damageReduction;
        private double _redirectChance;
        private double _itemFind;
        private double _goldFind;
        private double _experience;
        private double _movementSpeed;
        private double _captureRate;

        public double Power
        {
            get => _power;
            set => Set(ref _power, value);
        }
        public double Stamina
        {
            get => _stamina;
            set => Set(ref _stamina, value);
        }
        public double Agility
        {
            get => _agility;
            set => Set(ref _agility, value);
        }
        public double AltPower
        {
            get => _altPower;
            set => Set(ref _altPower, value);
        }
        public double AltStamina
        {
            get => _altStamina;
            set => Set(ref _altStamina, value);
        }
        public double AltAgility
        {
            get => _altAgility;
            set => Set(ref _altAgility, value);
        }
        public double DamageBonus
        {
            get => _damageBonus;
            set => Set(ref _damageBonus, value);
        }
        public double HealthBonus
        {
            get => _healthBonus;
            set => Set(ref _healthBonus, value);
        }
        public double SpeedBonus
        {
            get => _speedBonus;
            set => Set(ref _speedBonus, value);
        }
        public double CriticalChance
        {
            get => _criticalChance;
            set => Set(ref _criticalChance, value);
        }
        public double CriticalDamage
        {
            get => _criticalDamage;
            set => Set(ref _criticalDamage, value);
        }
        public double DamageEnrage
        {
            get => _damageEnrage;
            set => Set(ref _damageEnrage, value);
        }
        public double DualStrike
        {
            get => _dualStrike;
            set => Set(ref _dualStrike, value);
        }
        public double EmpowerChance
        {
            get => _empowerChance;
            set => Set(ref _empowerChance, value);
        }
        public double QuadStrike
        {
            get => _quadStrike;
            set => Set(ref _quadStrike, value);
        }
        public double EvadeChance
        {
            get => _evadeChance;
            set => Set(ref _evadeChance, value);
        }
        public double BlockChance
        {
            get => _blockChance;
            set => Set(ref _blockChance, value);
        }
        public double LifeSteal
        {
            get => _lifeSteal;
            set => Set(ref _lifeSteal, value);
        }
        public double DeflectChance
        {
            get => _deflectChance;
            set => Set(ref _deflectChance, value);
        }
        public double AbsorbChance
        {
            get => _absorbChance;
            set => Set(ref _absorbChance, value);
        }
        public double DamageReduction
        {
            get => _damageReduction;
            set => Set(ref _damageReduction, value);
        }
        public double RedirectChance
        {
            get => _redirectChance;
            set => Set(ref _redirectChance, value);
        }
        public double ItemFind
        {
            get => _itemFind;
            set => Set(ref _itemFind, value);
        }
        public double GoldFind
        {
            get => _goldFind;
            set => Set(ref _goldFind, value);
        }
        public double Experience
        {
            get => _experience;
            set => Set(ref _experience, value);
        }
        public double MovementSpeed
        {
            get => _movementSpeed;
            set => Set(ref _movementSpeed, value);
        }
        public double CaptureRate
        {
            get => _captureRate;
            set => Set(ref _captureRate, value);
        }

        public double TotalStats => Power + Stamina + Agility;
    }
}