using System.Collections.ObjectModel;
using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class EquipmentSectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _command;

        public RelayCommand Command => _command ?? (_command = new RelayCommand(CalculateStats));

        public ObservableCollection<BaseItemViewModel> List { get; set; }

        public MainhandViewModel Mainhand { get; set; }
        public OffhandViewModel Offhand { get; set; }
        public HeadViewModel Head { get; set; }
        public BodyViewModel Body { get; set; }
        public NeckViewModel Neck { get; set; }
        public RingViewModel Ring { get; set; }
        public PetViewModel Pet { get; set; }
        public AccessoryViewModel Accessory { get; set; }
        public MountViewModel Mount { get; set; }

        public EquipmentSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Mainhand = new MainhandViewModel
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
            };
            Offhand = new OffhandViewModel
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
            };
            Head = new HeadViewModel
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
            };
            Body = new BodyViewModel
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
            };
            Neck = new NeckViewModel
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
            };
            Ring = new RingViewModel
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
            };
            Accessory = new AccessoryViewModel
            {
                ItemName = "Volrea",
                Quality = ItemQuality.Rare,
                Stats =
                {
                    DamageReduction = 8,
                    AbsorbChance = 2
                }
            };
            Pet = new PetViewModel
            {
                ItemName = "Nammerz",
                Quality = ItemQuality.Rare
            };
            Mount = new MountViewModel
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
            };

            List = new ObservableCollection<BaseItemViewModel>
            {
                Mainhand,
                Offhand,
                Head,
                Body,
                Neck,
                Ring,
                Accessory,
                Pet,
                Mount
            };
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<EquipItemMessage<MainhandViewModel>>(this, m => { Mainhand = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<OffhandViewModel>>(this, m => { Offhand = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<HeadViewModel>>(this, m => { Head = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<BodyViewModel>>(this, m => { Body = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<NeckViewModel>>(this, m => { Neck = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<RingViewModel>>(this, m => { Ring = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<PetViewModel>>(this, m => { Pet = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<AccessoryViewModel>>(this, m => { Accessory = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<MountViewModel>>(this, m => { Mount = m.Vm; });
        }

        public void CalculateStats()
        {
            var stats = new StatsViewModel();

            foreach (BaseItemViewModel item in List)
            {
                stats.Power += item.Stats.Power;
                stats.Stamina += item.Stats.Stamina;
                stats.Agility += item.Stats.Agility;
                stats.DamageBonus += item.Stats.DamageBonus;
                stats.HealthBonus += item.Stats.HealthBonus;
                stats.SpeedBonus += item.Stats.SpeedBonus;
                stats.CriticalChance += item.Stats.CriticalChance;
                stats.CriticalDamage += item.Stats.CriticalDamage;
                stats.DamageEnrage += item.Stats.DamageEnrage;
                stats.DualStrike += item.Stats.DualStrike;
                stats.EmpowerChance += item.Stats.EmpowerChance;
                stats.QuadStrike += item.Stats.QuadStrike;
                stats.EvadeChance += item.Stats.EvadeChance;
                stats.BlockChance += item.Stats.BlockChance;
                stats.LifeSteal += item.Stats.LifeSteal;
                stats.DeflectChance += item.Stats.DeflectChance;
                stats.AbsorbChance += item.Stats.AbsorbChance;
                stats.DamageReduction += item.Stats.DamageReduction;
                stats.RedirectChance += item.Stats.RedirectChance;
                stats.ItemFind += item.Stats.ItemFind;
                stats.GoldFind += item.Stats.GoldFind;
                stats.Experience += item.Stats.Experience;
                stats.MovementSpeed += item.Stats.MovementSpeed;
                stats.CaptureRate += item.Stats.CaptureRate;
            }

            MessengerInstance.Send(new UpdateEquipmentStatsMessage(stats));
        }
    }
}