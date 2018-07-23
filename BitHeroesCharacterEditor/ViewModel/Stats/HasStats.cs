using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class HasStats : ViewModelBase
    {
        private StatsViewModel _stats;

        public StatsViewModel Stats
        {
            get => _stats;
            set => Set(ref _stats, value);
        }

        public HasStats()
        {
            Stats = new StatsViewModel();
        }
    }
}