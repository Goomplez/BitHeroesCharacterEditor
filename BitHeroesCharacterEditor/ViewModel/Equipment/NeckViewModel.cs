using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class NeckViewModel : BaseItemViewModel
    {
        public NeckViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Neck;
        }
    }
}