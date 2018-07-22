using BitHeroesCharacterEditor.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace BitHeroesCharacterEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            IMessenger messenger = new Messenger();

            var infoSectionViewModel = new InfoSectionViewModel(messenger);
            var equipmentSectionViewModel = new EquipmentSectionViewModel(messenger);
            var inventorySectionViewModel = new InventorySectionViewModel(messenger);
            var application = new BitHeroesCharacterEditorApplication(
                messenger,
                infoSectionViewModel,
                equipmentSectionViewModel,
                inventorySectionViewModel);

            InitializeComponent();

            InfoSection.DataContext = infoSectionViewModel;
            EquipmentSection.DataContext = equipmentSectionViewModel;
            InventorySection.DataContext = inventorySectionViewModel;
        }
    }
}