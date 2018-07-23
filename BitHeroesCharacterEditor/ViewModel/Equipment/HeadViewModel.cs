using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class HeadViewModel : BaseItemViewModel
    {
        public HeadViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Head;
        }
    }
}