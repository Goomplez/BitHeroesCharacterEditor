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

            var statsSectionViewModel = new StatsSectionViewModel(messenger);
            var equipmentSectionViewModel = new EquipmentSectionViewModel(messenger);
            var inventorySectionViewModel = new InventorySectionViewModel(messenger);

            InitializeComponent();

            StatsSection.DataContext = statsSectionViewModel;
            EquipmentSection.DataContext = equipmentSectionViewModel;
            InventorySection.DataContext = inventorySectionViewModel;
        }
    }
}