using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class BitHeroesCharacterEditorApplication : ViewModelBase
    {
        private InfoSectionViewModel _infoSection;
        private EquipmentSectionViewModel _equipmentSection;
        private InventorySectionViewModel _inventorySection;

        public BitHeroesCharacterEditorApplication(
            IMessenger messenger,
            InfoSectionViewModel infoSection,
            EquipmentSectionViewModel equipmentSection,
            InventorySectionViewModel inventorySection)
        {
            MessengerInstance = messenger;
            _infoSection = infoSection;
            _equipmentSection = equipmentSection;
            _inventorySection = inventorySection;

            _equipmentSection.List = new ObservableCollection<BaseItemViewModel>();
            _equipmentSection.Runes = new ObservableCollection<BaseItemViewModel>();
            _inventorySection.List = new ObservableCollection<BaseItemViewModel>();
        }
    }
}