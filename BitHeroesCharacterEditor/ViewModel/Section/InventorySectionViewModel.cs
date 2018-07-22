using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class InventorySectionViewModel : BaseSectionViewModel
    {
        public FilterViewModel Filter { get; set; } = new FilterViewModel();

        public InventorySectionViewModel(
            IMessenger messenger)
            : base(messenger)
        {

        }

        protected override void RegisterMessages()
        {

        }
    }
}