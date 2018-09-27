using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class MainhandViewModel : BaseItemViewModel
    {
        private WeaponType _weaponType;

        public WeaponType WeaponType
        {
            get => _weaponType;
            set => Set(ref _weaponType, value);
    }

        public MainhandViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            //Slot = EquipmentType.Mainhand;
        }
    }
}