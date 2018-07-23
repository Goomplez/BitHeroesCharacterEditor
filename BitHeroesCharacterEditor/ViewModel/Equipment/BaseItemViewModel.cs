using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseItemViewModel : HasStats
    {
        public string ItemName { get; set; }
        public int Tier { get; set; }
        public  ItemSlot Slot { get; protected set; }
        public ItemQuality Quality { get; set; }

        public BaseItemViewModel(IMessenger messenger)
        {
            MessengerInstance = messenger;
        }

        private RelayCommand _selectItemCommand;

        public RelayCommand SelectItemCommand => _selectItemCommand ?? (_selectItemCommand = new RelayCommand(SelectItem));

        private void SelectItem()
        {
            MessengerInstance.Send(new SelectItemMessage(this));
        }
    }
}