using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class OffhandViewModel : BaseItemViewModel
    {
        public OffhandViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Offhand;
        }
    }
}