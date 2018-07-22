using BitHeroesCharacterEditor.ViewModel;

namespace BitHeroesCharacterEditor.Message
{
    public class UpdateInventoryStatsMessage
    {
        public UpdateInventoryStatsMessage(StatsViewModel vm)
        {
            Vm = vm;
        }

        public StatsViewModel Vm { get; }
    }
}