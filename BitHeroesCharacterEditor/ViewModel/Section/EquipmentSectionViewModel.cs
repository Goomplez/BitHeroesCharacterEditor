using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class EquipmentSectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _command;

        public RelayCommand Command => _command != null ? _command : _command = new RelayCommand(Method);

        public EquipmentSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {

        }

        protected override void RegisterMessages()
        {

        }

        public void Method()
        {
            MessengerInstance.Send(new TestMessage("test"));
        }
    }
}