using System.Collections.ObjectModel;
using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class EquipmentSectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _openRunesCommand;
        private RelayCommand _openEnchantsCommand;
        private MainhandViewModel _mainhand;
        private OffhandViewModel _offhand;
        private HeadViewModel _head;
        private BodyViewModel _body;
        private NeckViewModel _neck;
        private RingViewModel _ring;
        private AccessoryViewModel _accessory;
        private PetViewModel _pet;
        private MountViewModel _mount;
        private bool _isRunesOpen;
        private bool _isEnchantsOpen;

        public RelayCommand OpenRunesCommand => _openRunesCommand ?? (_openRunesCommand = new RelayCommand(OpenRunes));
        public RelayCommand OpenEnchantsCommand => _openEnchantsCommand ?? (_openEnchantsCommand = new RelayCommand(OpenEnchants));
        public MainhandViewModel Mainhand
        {
            get => _mainhand;
            set
            {
                Set(ref _mainhand, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public OffhandViewModel Offhand
        {
            get => _offhand;
            set
            {
                Set(ref _offhand, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public HeadViewModel Head
        {
            get => _head;
            set
            {
                Set(ref _head, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public BodyViewModel Body
        {
            get => _body;
            set
            {
                Set(ref _body, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public NeckViewModel Neck
        {
            get => _neck;
            set
            {
                Set(ref _neck, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public RingViewModel Ring
        {
            get => _ring;
            set
            {
                Set(ref _ring, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public PetViewModel Pet
        {
            get => _pet;
            set
            {
                Set(ref _pet, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public AccessoryViewModel Accessory
        {
            get => _accessory;
            set
            {
                Set(ref _accessory, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public MountViewModel Mount
        {
            get => _mount;
            set
            {
                Set(ref _mount, value);
                UpdateItemsList();
                CalculateEquipmentStats();
            }
        }
        public bool IsRunesOpen
        {
            get => _isRunesOpen;
            set => Set(ref _isRunesOpen, value);
        }
        public bool IsEnchantsOpen
        {
            get => _isEnchantsOpen;
            set => Set(ref _isEnchantsOpen, value);
        }

        public ObservableCollection<BaseItemViewModel> List { get; set; } = new ObservableCollection<BaseItemViewModel>();
        public ObservableCollection<BaseItemViewModel> Runes { get; set; } = new ObservableCollection<BaseItemViewModel>();
        public ObservableCollection<BaseItemViewModel> Enchants { get; set; } = new ObservableCollection<BaseItemViewModel>();

        public EquipmentSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {

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

        private void OpenRunes()
        {
            IsRunesOpen = !IsRunesOpen;
        }

        private void OpenEnchants()
        {
            IsEnchantsOpen = !IsEnchantsOpen;
        }

        private void UpdateItemsList()
        {
            List.Clear();
            if (Mainhand != null) List.Add(Mainhand);
            if (Offhand != null) List.Add(Offhand);
            if (Head != null) List.Add(Head);
            if (Body != null) List.Add(Body);
            if (Neck != null) List.Add(Neck);
            if (Ring != null) List.Add(Ring);
            if (Pet != null) List.Add(Pet);
            if (Accessory != null) List.Add(Accessory);
            if (Mount != null) List.Add(Mount);
        }

        private void CalculateEquipmentStats()
        {
            Stats = new StatsViewModel();

            AddToStats(List);
            AddToStats(Runes);
            AddToStats(Enchants);

            MessengerInstance.Send(new UpdateInfoSectionMessage(Stats));
        }

        private void AddToStats(ObservableCollection<BaseItemViewModel> items)
        {
            if (items == null) return;

            foreach (var item in items)
            {
                Stats.Power += item.Stats.Power;
                Stats.Stamina += item.Stats.Stamina;
                Stats.Agility += item.Stats.Agility;
                Stats.DamageBonus += item.Stats.DamageBonus;
                Stats.HealthBonus += item.Stats.HealthBonus;
                Stats.SpeedBonus += item.Stats.SpeedBonus;
                Stats.CriticalChance += item.Stats.CriticalChance;
                Stats.CriticalDamage += item.Stats.CriticalDamage;
                Stats.DamageEnrage += item.Stats.DamageEnrage;
                Stats.DualStrike += item.Stats.DualStrike;
                Stats.EmpowerChance += item.Stats.EmpowerChance;
                Stats.QuadStrike += item.Stats.QuadStrike;
                Stats.EvadeChance += item.Stats.EvadeChance;
                Stats.BlockChance += item.Stats.BlockChance;
                Stats.LifeSteal += item.Stats.LifeSteal;
                Stats.DeflectChance += item.Stats.DeflectChance;
                Stats.AbsorbChance += item.Stats.AbsorbChance;
                Stats.DamageReduction += item.Stats.DamageReduction;
                Stats.RedirectChance += item.Stats.RedirectChance;
                Stats.ItemFind += item.Stats.ItemFind;
                Stats.GoldFind += item.Stats.GoldFind;
                Stats.Experience += item.Stats.Experience;
                Stats.MovementSpeed += item.Stats.MovementSpeed;
                Stats.CaptureRate += item.Stats.CaptureRate;
            }
        }
    }
}