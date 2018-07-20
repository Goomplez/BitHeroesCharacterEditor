using BitHeroesCharacterEditor.ViewModel;
using System.Windows;

namespace BitHeroesCharacterEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var statsSectionViewModel = new StatsSectionViewModel();
            var equipmentSectionViewModel = new EquipmentSectionViewModel();
            var inventorySectionViewModel = new InventorySectionViewModel();

            InitializeComponent();

            StatsSection.DataContext = statsSectionViewModel;
            EquipmentSection.DataContext = equipmentSectionViewModel;
            InventorySection.DataContext = inventorySectionViewModel;
        }
    }
}