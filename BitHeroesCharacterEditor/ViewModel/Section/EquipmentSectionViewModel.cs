using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class EquipmentSectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _command;

        public RelayCommand Command => _command ?? (_command = new RelayCommand(Method));

        public MainhandViewModel Mainhand { get; set; }
        public OffhandViewModel Offhand { get; set; }
        public HeadViewModel Head { get; set; }
        public BodyViewModel Body { get; set; }
        public NeckViewModel Neck { get; set; }
        public FingerViewModel Finger { get; set; }
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
                Power = 20,
                Stamina = 240,
                Agility = 20
            };
            Offhand = new OffhandViewModel
            {
                ItemName = "Flight Calibrator",
                Quality = ItemQuality.Epic,
                Tier = 7,
                Power = 18,
                Stamina = 156,
                Agility = 18
            };
            Head = new HeadViewModel
            {
                ItemName = "Eye Of Treachery",
                Quality = ItemQuality.Legendary,
                Tier = 6,
                Power = 20,
                Stamina = 170,
                Agility = 20
            };
            Body = new BodyViewModel
            {
                ItemName = "Surveyor's Garb",
                Quality = ItemQuality.Epic,
                Tier = 7,
                Power = 18,
                Stamina = 156,
                Agility = 18
            };
            Neck = new NeckViewModel
            {
                ItemName = "Mechanical Enhancement",
                Quality = ItemQuality.Epic,
                Tier = 7,
                Power = 132,
                Stamina = 30,
                Agility = 30
            };
            Finger = new FingerViewModel
            {
                ItemName = "Robotics Chip",
                Quality = ItemQuality.Epic,
                Tier = 7,
                Power = 132,
                Stamina = 30,
                Agility = 30
            };
            Accessory = new AccessoryViewModel
            {
                ItemName = "Volrea",
                Quality = ItemQuality.Rare
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
                Power = 188,
                Stamina = 0,
                Agility = 4
            };
        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<EquipItemMessage<MainhandViewModel>>(this, m => { Mainhand = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<OffhandViewModel>>(this, m => { Offhand = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<HeadViewModel>>(this, m => { Head = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<BodyViewModel>>(this, m => { Body = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<NeckViewModel>>(this, m => { Neck = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<FingerViewModel>>(this, m => { Finger = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<PetViewModel>>(this, m => { Pet = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<AccessoryViewModel>>(this, m => { Accessory = m.Vm; });
            MessengerInstance.Register<EquipItemMessage<MountViewModel>>(this, m => { Mount = m.Vm; });
        }

        public void Method()
        {
            MessengerInstance.Send(new TestMessage("test"));
        }
    }
}