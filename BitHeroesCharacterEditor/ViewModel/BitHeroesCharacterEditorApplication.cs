using System.Collections.ObjectModel;
using BitHeroesCharacterEditor.Model;
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

            _equipmentSection.List = new ObservableCollection<BaseItemViewModel>();
            _inventorySection.List = GetItemsList(messenger);

            _equipmentSection.CalculateStats();
        }

        public void RegisterMessages()
        {

        }

        public ObservableCollection<BaseItemViewModel> GetItemsList(IMessenger messenger)
        {
            return new ObservableCollection<BaseItemViewModel>
            {
                new MainhandViewModel(messenger)
                {
                    ItemName = "Aptitude",
                    Quality = ItemQuality.Legendary,
                    Tier = 7,
                    Stats =
                    {
                        Power = 20,
                        Stamina = 240,
                        Agility = 20
                    }
                },
                new OffhandViewModel(messenger)
                {
                    ItemName = "Flight Calibrator",
                    Quality = ItemQuality.Epic,
                    Tier = 7,
                    Stats =
                    {
                        Power = 18,
                        Stamina = 156,
                        Agility = 18
                    }
                },
                new HeadViewModel(messenger)
                {
                    ItemName = "Eye Of Treachery",
                    Quality = ItemQuality.Legendary,
                    Tier = 6,
                    Stats =
                    {
                        Power = 20,
                        Stamina = 170,
                        Agility = 20
                    }
                },
                new BodyViewModel(messenger)
                {
                    ItemName = "Surveyor's Garb",
                    Quality = ItemQuality.Epic,
                    Tier = 7,
                    Stats =
                    {
                        Power = 18,
                        Stamina = 156,
                        Agility = 18
                    }
                },
                new NeckViewModel(messenger)
                {
                    ItemName = "Mechanical Enhancement",
                    Quality = ItemQuality.Epic,
                    Tier = 7,
                    Stats =
                    {
                        Power = 132,
                        Stamina = 30,
                        Agility = 30
                    }
                },
                new RingViewModel(messenger)
                {
                    ItemName = "Robotics Chip",
                    Quality = ItemQuality.Epic,
                    Tier = 7,
                    Stats =
                    {
                        Power = 132,
                        Stamina = 30,
                        Agility = 30
                    }
                },
                new AccessoryViewModel(messenger)
                {
                    ItemName = "Volrea",
                    Quality = ItemQuality.Rare,
                    Stats =
                    {
                        DamageReduction = 8,
                        AbsorbChance = 2
                    }
                },
                new PetViewModel(messenger)
                {
                    ItemName = "Nammerz",
                    Quality = ItemQuality.Rare
                },
                new MountViewModel(messenger)
                {
                    ItemName = "Tort",
                    Quality = ItemQuality.Epic,
                    Tier = 7,
                    Stats =
                    {
                        Power = 188,
                        Stamina = 0,
                        Agility = 4,
                        EvadeChance = 3,
                        MovementSpeed = 20
                    }
                }
            };
        }
    }
}