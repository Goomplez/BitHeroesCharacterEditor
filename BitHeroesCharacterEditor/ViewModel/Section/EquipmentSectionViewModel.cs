using System.Collections.ObjectModel;
using BitHeroesCharacterEditor.Message;
using BitHeroesCharacterEditor.Message.Equipment;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class EquipmentSectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _command;

        public RelayCommand Command => _command ?? (_command = new RelayCommand(Method));

        public ObservableCollection<BaseItemViewModel> Items { get; set; }

        public MainhandViewModel Mainhand { get; set; } = new MainhandViewModel();
        public OffhandViewModel Offhand { get; set; } = new OffhandViewModel();
        public HeadViewModel Head { get; set; } = new HeadViewModel();
        public BodyViewModel Body { get; set; } = new BodyViewModel();
        public NeckViewModel Neck { get; set; } = new NeckViewModel();
        public FingerViewModel Finger { get; set; } = new FingerViewModel();
        public PetViewModel Pet { get; set; } = new PetViewModel();
        public AccessoryViewModel Accessory { get; set; } = new AccessoryViewModel();
        public MountViewModel Mount { get; set; } = new MountViewModel();

        public EquipmentSectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Items = new ObservableCollection<BaseItemViewModel>();
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