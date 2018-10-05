using System.Collections.ObjectModel;
using BitHeroesCharacterEditor.Message;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InventorySectionViewModel : BaseSectionViewModel
    {
        private RelayCommand _equipItemCommand;

        public RelayCommand EquipItemCommand => _equipItemCommand ?? (_equipItemCommand = new RelayCommand(EquipItem));

        private BaseItemViewModel _currentItem;

        public FilterViewModel Filter { get; set; } = new FilterViewModel();
        public ObservableCollection<BaseItemViewModel> List { get; set; } = new ObservableCollection<BaseItemViewModel>();
        public BaseItemViewModel CurrentItem
        {
            get => _currentItem;
            set => Set(ref _currentItem, value);
        }

        public InventorySectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {

        }

        protected override void RegisterMessages()
        {
            MessengerInstance.Register<SelectItemMessage>(this, m => { CurrentItem = m.Vm; });
        }

        public void EquipItem()
        {
            var typeString = CurrentItem?.ToString();

            if (string.IsNullOrEmpty(typeString)) return;

            if (typeString.Contains("Mainhand")) MessengerInstance.Send(new EquipItemMessage<MainhandViewModel>(CurrentItem as MainhandViewModel));
            if (typeString.Contains("Offhand")) MessengerInstance.Send(new EquipItemMessage<OffhandViewModel>(CurrentItem as OffhandViewModel));
            if (typeString.Contains("Head")) MessengerInstance.Send(new EquipItemMessage<HeadViewModel>(CurrentItem as HeadViewModel));
            if (typeString.Contains("Body")) MessengerInstance.Send(new EquipItemMessage<BodyViewModel>(CurrentItem as BodyViewModel));
            if (typeString.Contains("Neck")) MessengerInstance.Send(new EquipItemMessage<NeckViewModel>(CurrentItem as NeckViewModel));
            if (typeString.Contains("Ring")) MessengerInstance.Send(new EquipItemMessage<RingViewModel>(CurrentItem as RingViewModel));
            if (typeString.Contains("Accessory")) MessengerInstance.Send(new EquipItemMessage<AccessoryViewModel>(CurrentItem as AccessoryViewModel));
            if (typeString.Contains("Pet")) MessengerInstance.Send(new EquipItemMessage<PetViewModel>(CurrentItem as PetViewModel));
            if (typeString.Contains("Mount")) MessengerInstance.Send(new EquipItemMessage<MountViewModel>(CurrentItem as MountViewModel));
        }
    }
}