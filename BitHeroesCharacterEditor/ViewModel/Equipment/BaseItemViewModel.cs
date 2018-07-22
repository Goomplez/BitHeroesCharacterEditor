using BitHeroesCharacterEditor.Model;

namespace BitHeroesCharacterEditor.ViewModel
{
    public abstract class BaseItemViewModel : HasStats
    {
        public string ItemName { get; set; }
        public int Tier { get; set; }
        public  ItemSlot Slot { get; protected set; }
        public ItemQuality Quality { get; set; }

        public BaseItemViewModel()
        {

        }
    }
}