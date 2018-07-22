using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseItemViewModel : ViewModelBase
    {
        public string ItemName { get; set; }
        public int Tier { get; set; }
        public  ItemSlot Slot { get; protected set; }
        public ItemQuality Quality { get; set; }
        public int Power { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
 
        public BaseItemViewModel()
        {

        }
    }
}