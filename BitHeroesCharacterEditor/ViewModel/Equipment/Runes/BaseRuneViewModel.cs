using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class BaseRuneViewModel : BaseItemViewModel
    {
        private string _runeName;
        private RuneType _type;

        public string RuneName
        {
            get => _runeName;
            set => Set(ref _runeName, value);
        }
        public RuneType Type
        {
            get => _type;
            set => Set(ref _type, value);
        }

        public BaseRuneViewModel(
            IMessenger messenger)
            : base(messenger)
        {

        }
    }
}