using BitHeroesCharacterEditor.ViewModel;

namespace BitHeroesCharacterEditor.Message
{
    public class UpdateEquipmentStatsMessage
    {
        public UpdateEquipmentStatsMessage(StatsViewModel vm)
        {
            Vm = vm;
        }

        public StatsViewModel Vm { get; }
    }
}