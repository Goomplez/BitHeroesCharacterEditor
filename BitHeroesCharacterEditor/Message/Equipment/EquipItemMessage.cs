namespace BitHeroesCharacterEditor.Message.Equipment
{
    public class EquipItemMessage<T>
    {
        public EquipItemMessage(T vm)
        {
            Vm = vm;
        }

        public T Vm { get; }
    }
}