using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class StatsViewModel : ViewModelBase
    {
        private int _power;
        private int _stamina;
        private int _agility;
        private int _altPower;
        private int _altStamina;
        private int _altAgility;
        private int _damageBonus;
        private int _healthBonus;
        private int _speedBonus;
        private int _criticalChance;
        private int _criticalDamage;
        private int _damageEnrage;
        private int _dualStrike;
        private int _empowerChance;
        private int _quadStrike;
        private int _evadeChance;
        private int _blockChance;
        private int _lifeSteal;
        private int _deflectChance;
        private int _absorbChance;
        private int _damageReduction;
        private int _redirectChance;
        private int _itemFind;
        private int _goldFind;
        private int _experience;
        private int _movementSpeed;
        private int _captureRate;

        public int Power
        {
            get => _power;
            set => Set(ref _power, value);
        }
        public int Stamina
        {
            get => _stamina;
            set => Set(ref _stamina, value);
        }
        public int Agility
        {
            get => _agility;
            set => Set(ref _agility, value);
        }
        public int AltPower
        {
            get => _altPower;
            set => Set(ref _altPower, value);
        }
        public int AltStamina
        {
            get => _altStamina;
            set => Set(ref _altStamina, value);
        }
        public int AltAgility
        {
            get => _altAgility;
            set => Set(ref _altAgility, value);
        }
        public int DamageBonus
        {
            get => _damageBonus;
            set => Set(ref _damageBonus, value);
        }
        public int HealthBonus
        {
            get => _healthBonus;
            set => Set(ref _healthBonus, value);
        }
        public int SpeedBonus
        {
            get => _speedBonus;
            set => Set(ref _speedBonus, value);
        }
        public int CriticalChance
        {
            get => _criticalChance;
            set => Set(ref _criticalChance, value);
        }
        public int CriticalDamage
        {
            get => _criticalDamage;
            set => Set(ref _criticalDamage, value);
        }
        public int DamageEnrage
        {
            get => _damageEnrage;
            set => Set(ref _damageEnrage, value);
        }
        public int DualStrike
        {
            get => _dualStrike;
            set => Set(ref _dualStrike, value);
        }
        public int EmpowerChance
        {
            get => _empowerChance;
            set => Set(ref _empowerChance, value);
        }
        public int QuadStrike
        {
            get => _quadStrike;
            set => Set(ref _quadStrike, value);
        }
        public int EvadeChance
        {
            get => _evadeChance;
            set => Set(ref _evadeChance, value);
        }
        public int BlockChance
        {
            get => _blockChance;
            set => Set(ref _blockChance, value);
        }
        public int LifeSteal
        {
            get => _lifeSteal;
            set => Set(ref _lifeSteal, value);
        }
        public int DeflectChance
        {
            get => _deflectChance;
            set => Set(ref _deflectChance, value);
        }
        public int AbsorbChance
        {
            get => _absorbChance;
            set => Set(ref _absorbChance, value);
        }
        public int DamageReduction
        {
            get => _damageReduction;
            set => Set(ref _damageReduction, value);
        }
        public int RedirectChance
        {
            get => _redirectChance;
            set => Set(ref _redirectChance, value);
        }
        public int ItemFind
        {
            get => _itemFind;
            set => Set(ref _itemFind, value);
        }
        public int GoldFind
        {
            get => _goldFind;
            set => Set(ref _goldFind, value);
        }
        public int Experience
        {
            get => _experience;
            set => Set(ref _experience, value);
        }
        public int MovementSpeed
        {
            get => _movementSpeed;
            set => Set(ref _movementSpeed, value);
        }
        public int CaptureRate
        {
            get => _captureRate;
            set => Set(ref _captureRate, value);
        }

        public int TotalStats => Power + Stamina + Agility;
    }
}