using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class StatsViewModel : ViewModelBase
    {
        #region Stats

        public int Power { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int TotalStats => Power + Stamina + Agility;
        public int DamageBonus { get; set; }
        public int HealthBonus { get; set; }
        public int SpeedBonus { get; set; }

        #endregion
        #region Offensive Bonuses

        public int CriticalChance { get; set; }
        public int CriticalDamage { get; set; }
        public int DamageEnrage { get; set; }
        public int DualStrike { get; set; }
        public int EmpowerChance { get; set; }
        public int QuadStrike { get; set; }

        #endregion
        #region Defensive Bonuses

        public int EvadeChance { get; set; }
        public int BlockChance { get; set; }
        public int LifeSteal { get; set; }
        public int DeflectChance { get; set; }
        public int AbsorbChance { get; set; }
        public int DamageReduction { get; set; }
        public int RedirectChance { get; set; }

        #endregion
        #region Passive Bonuses

        public int ItemFind { get; set; }
        public int GoldFind { get; set; }
        public int Experience { get; set; }
        public int MovementSpeed { get; set; }
        public int CaptureRate { get; set; }

        #endregion
    }
}