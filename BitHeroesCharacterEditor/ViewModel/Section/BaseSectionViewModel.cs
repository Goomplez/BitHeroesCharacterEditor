using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseSectionViewModel : HasStats
    {
        public BaseSectionViewModel(IMessenger messenger)
        {
            MessengerInstance = messenger;

            RegisterMessages();
        }

        protected abstract void RegisterMessages();
    }
}