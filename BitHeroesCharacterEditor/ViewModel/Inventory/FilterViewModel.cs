using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class FilterViewModel : ViewModelBase
    {
        private RelayCommand _showFilterCommand;

        public RelayCommand ShowFilterCommand => _showFilterCommand ?? (_showFilterCommand = new RelayCommand(ShowFilter));

        private bool _isShowingFilters;
        public bool IsShowingFilters
        {
            get => _isShowingFilters;
            set => Set(ref _isShowingFilters, value);
        }

        public bool Uncommon { get; set; }
        public bool Common { get; set; }
        public bool Rare { get; set; }
        public bool Epic { get; set; }
        public bool Legendary { get; set; }
        public bool Set { get; set; }
        public bool Mythic { get; set; }

        public bool Tier1 { get; set; }
        public bool Tier2 { get; set; }
        public bool Tier3 { get; set; }
        public bool Tier4 { get; set; }
        public bool Tier5 { get; set; }
        public bool Tier6 { get; set; }
        public bool Tier7 { get; set; }
        public bool Tier8 { get; set; }

        public bool Mainhand { get; set; }
        public bool Offhand { get; set; }
        public bool Head { get; set; }
        public bool Body { get; set; }
        public bool Neck { get; set; }
        public bool Ring { get; set; }
        public bool Accessory { get; set; }
        public bool Pet { get; set; }
        public bool Mount { get; set; }

        private void ShowFilter()
        {
            IsShowingFilters = !IsShowingFilters;
        }
    }
}