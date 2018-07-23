using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class BodyViewModel : BaseItemViewModel
    {
        public BodyViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Body;
        }
    }
}