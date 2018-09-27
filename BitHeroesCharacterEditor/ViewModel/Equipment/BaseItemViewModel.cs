using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseItemViewModel : HasStats
    {
        private string _itemName;
        private int _tier;
        private EquipmentType _slot;
        private ItemQuality _quality;

        public string ItemName
        {
            get => _itemName;
            set => Set(ref _itemName, value);
        }
        public int Tier
        {
            get => _tier;
            set => Set(ref _tier, value);
        }
        public EquipmentType Slot
        {
            get => _slot;
            set => Set(ref _slot, value);
        }
        public ItemQuality Quality
        {
            get => _quality;
            set => Set(ref _quality, value);
        }

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