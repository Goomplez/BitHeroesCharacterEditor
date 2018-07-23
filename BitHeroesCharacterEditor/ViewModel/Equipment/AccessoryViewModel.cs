using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class AccessoryViewModel : BaseItemViewModel
    {
        public AccessoryViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Accessory;
        }
    }
}