using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class MainhandViewModel : BaseItemViewModel
    {
        public MainhandViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Mainhand;
        }
    }
}