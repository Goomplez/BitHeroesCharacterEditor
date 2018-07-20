using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseSectionViewModel : ViewModelBase
    {
        public BaseSectionViewModel(IMessenger messenger)
        {
            MessengerInstance = messenger;

            RegisterMessages();
        }

        protected abstract void RegisterMessages();
    }
}