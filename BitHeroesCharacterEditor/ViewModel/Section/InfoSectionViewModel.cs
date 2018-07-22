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

        }
    }
}