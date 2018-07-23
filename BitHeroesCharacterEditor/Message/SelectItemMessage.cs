using BitHeroesCharacterEditor.ViewModel;

namespace BitHeroesCharacterEditor.Message
{
    public class SelectItemMessage
    {
        public SelectItemMessage(BaseItemViewModel vm)
        {
            Vm = vm;
        }

        public BaseItemViewModel Vm { get; }
    }
}