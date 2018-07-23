using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InventorySectionViewModel : BaseSectionViewModel
    {
        public FilterViewModel Filter { get; set; } = new FilterViewModel();
        public BaseItemViewModel CurrentItem { get; set; }
        public ObservableCollection<BaseItemViewModel> List { get; set; }

        public InventorySectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            var items = new List<BaseItemViewModel>
            {
                new MainhandViewModel
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
                new OffhandViewModel
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
                new HeadViewModel
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
                new BodyViewModel
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
                new NeckViewModel
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
                new RingViewModel
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
                new AccessoryViewModel
                {
                    ItemName = "Volrea",
                    Quality = ItemQuality.Rare,
                    Stats =
                    {
                        DamageReduction = 8,
                        AbsorbChance = 2
                    }
                },
                new PetViewModel
                {
                    ItemName = "Nammerz",
                    Quality = ItemQuality.Rare
                },
                new MountViewModel
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
            }.OrderByDescending(x => (int)x.Quality);
            List = new ObservableCollection<BaseItemViewModel>(items);
            CurrentItem = List.FirstOrDefault();
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<SelectItemMessage>(this, m => { CurrentItem = m.Vm; });
        }
    }
}