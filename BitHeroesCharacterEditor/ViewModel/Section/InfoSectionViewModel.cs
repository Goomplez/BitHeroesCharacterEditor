using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InfoSectionViewModel : BaseSectionViewModel
    {
        public StatsViewModel Stats { get; set; }

        public InfoSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<UpdateStatsMessage>(this, m =>
            {
                Stats = m.Vm;
            });
        }
    }
}