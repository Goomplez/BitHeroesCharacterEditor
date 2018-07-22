using BitHeroesCharacterEditor.ViewModel;

namespace BitHeroesCharacterEditor.Message
{
    public class UpdateStatsMessage
    {
        public UpdateStatsMessage(StatsViewModel vm)
        {
            Vm = vm;
        }

        public StatsViewModel Vm { get; }
    }
}