﻿using BitHeroesCharacterEditor.Model;
using GalaSoft.MvvmLight.Messaging;

namespace BitHeroesCharacterEditor.ViewModel
{
    public class PetViewModel : BaseItemViewModel
    {
        public PetViewModel(
            IMessenger messenger)
            : base(messenger)
        {
            Slot = ItemSlot.Pet;
        }
    }
}