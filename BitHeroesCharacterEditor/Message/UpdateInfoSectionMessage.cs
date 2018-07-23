using BitHeroesCharacterEditor.ViewModel;

namespace BitHeroesCharacterEditor.Message
{
    public class UpdateInfoSectionMessage
    {
        public UpdateInfoSectionMessage(StatsViewModel vm)
        {
            Vm = vm;
        }

        public StatsViewModel Vm { get; }
    }
}