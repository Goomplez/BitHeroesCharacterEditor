using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class StatsSectionViewModel : BaseSectionViewModel
    {
        #region Stats

        public int Power;
        public int Stamina;
        public int Agility;
        public int TotalStats;
        public int DamageBonus;
        public int HealthBonus;
        public int SpeedBonus;
        public int CriticalChance;
        public int CriticalDamage;
        public int EvadeChance;
        public int BlockChance;
        public int LifeSteal;
        public int DamageEnrage;
        public int DeflectChance;
        public int AbsorbChance;
        public int DamageReduction;
        public int DualStrike;
        public int EmpowerChance;
        public int RedirectChance;
        public int QuadStrike;

        #endregion

        #region Bonuses

        public int ItemFind;
        public int GoldFind;
        public int Experience;
        public int MovementSpeed;
        public int CaptureRate;

        #endregion

        public StatsSectionViewModel(
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