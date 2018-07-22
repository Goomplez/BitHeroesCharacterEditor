using BitHeroesCharacterEditor.Message;
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

            RegisterMessages();

            _equipmentSection.CalculateStats();
        }

        public void RegisterMessages()
        {
            MessengerInstance.Register<UpdateEquipmentStatsMessage>(this, m =>
            {
                _infoSection.Stats = m.Vm;
                _equipmentSection.Stats = m.Vm;
            });
            MessengerInstance.Register<UpdateInventoryStatsMessage>(this, m =>
            {
                _inventorySection.Stats = m.Vm;
            });
        }
    }
}