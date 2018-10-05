using BitHeroesCharacterEditor.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using BitHeroesCharacterEditor.Database;

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
            //var application = new BitHeroesCharacterEditorApplication(messenger, infoSectionViewModel, equipmentSectionViewModel, inventorySectionViewModel);

            InitializeComponent();

            InfoSection.DataContext = infoSectionViewModel;
            EquipmentSection.DataContext = equipmentSectionViewModel;
            InventorySection.DataContext = inventorySectionViewModel;

            var sql = new SqliteService(messenger);

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