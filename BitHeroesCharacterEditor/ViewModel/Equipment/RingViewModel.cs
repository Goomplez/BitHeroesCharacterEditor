using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class RingViewModel : BaseItemViewModel
    {
        public RingViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Ring;
        }
    }
}