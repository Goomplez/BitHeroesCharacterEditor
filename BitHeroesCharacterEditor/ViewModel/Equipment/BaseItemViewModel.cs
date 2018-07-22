using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class BaseItemViewModel : ViewModelBase
    {
        public ItemSlot Slot { get; set; }
        public ItemQuality Quality { get; set; }
        public int Power { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public string Tooltip { get; set; }
 
        public BaseItemViewModel()
        {

        }
    }
}