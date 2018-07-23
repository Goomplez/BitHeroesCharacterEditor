using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class MountViewModel : BaseItemViewModel
    {
        public MountViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Mount;
        }
    }
}