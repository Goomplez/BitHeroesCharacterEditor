using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class HasStats : ViewModelBase
    {
        public StatsViewModel Stats { get; set; } = new StatsViewModel();
    }
}