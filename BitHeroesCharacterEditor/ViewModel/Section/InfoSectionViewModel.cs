using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InfoSectionViewModel : BaseSectionViewModel
    {
        public InfoSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<UpdateInfoSectionMessage>(this, m => { Stats = m.Vm; });
        }
    }
}