using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InfoSectionViewModel : BaseSectionViewModel
    {
        #region Stats

        public int Power;
        public int Stamina;
        public int Agility;
        public int TotalStats;
        public int DamageBonus;
        public int HealthBonus;
        public int SpeedBonus;

        #endregion
        #region Offensive Bonuses

        public int CriticalChance;
        public int CriticalDamage;
        public int DamageEnrage;
        public int DualStrike;
        public int EmpowerChance;
        public int QuadStrike;

        #endregion
        #region Defensive Bonuses

        public int EvadeChance;
        public int BlockChance;
        public int LifeSteal;
        public int DeflectChance;
        public int AbsorbChance;
        public int DamageReduction;
        public int RedirectChance;

        #endregion
        #region Passive Bonuses

        public int ItemFind;
        public int GoldFind;
        public int Experience;
        public int MovementSpeed;
        public int CaptureRate;

        #endregion

        public InfoSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<TestMessage>(this, m =>
            {
                return;
            });
        }
    }
}