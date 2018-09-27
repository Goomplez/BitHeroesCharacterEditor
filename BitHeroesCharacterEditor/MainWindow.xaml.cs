using BitHeroesCharacterEditor.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using BitHeroesCharacterEditor.Database;

namespace BitHeroesCharacterEditor
{
    public partial class MainWindow : Window
    {
        private InfoSectionViewModel infoSectionViewModel;
        private EquipmentSectionViewModel equipmentSectionViewModel;
        private InventorySectionViewModel inventorySectionViewModel;
        private BitHeroesCharacterEditorApplication application;

        public MainWindow()
        {
            IMessenger messenger = new Messenger();

            infoSectionViewModel = new InfoSectionViewModel(messenger);
            equipmentSectionViewModel = new EquipmentSectionViewModel(messenger);
            inventorySectionViewModel = new InventorySectionViewModel(messenger);
            application = new BitHeroesCharacterEditorApplication(messenger, infoSectionViewModel, equipmentSectionViewModel, inventorySectionViewModel);

            InitializeComponent();

            InfoSection.DataContext = infoSectionViewModel;
            EquipmentSection.DataContext = equipmentSectionViewModel;
            InventorySection.DataContext = inventorySectionViewModel;

            SqliteService sql = new SqliteService(messenger);
            foreach (var rune in sql.SelectAllRunes())
            {
                equipmentSectionViewModel.Runes.Add(rune);
            }

            foreach (var item in sql.SelectAllEquipment())
            {
                inventorySectionViewModel.List.Add(item);
            }
        }
    }
}