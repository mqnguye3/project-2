using System.Collections;
using System.Collections.Generic;
using PN.Equipment;
using UnityEngine;


namespace PN.UI
{
    public interface IDroppables
    {
        public void AddItem(ItemSO item);

        public ItemSO GetItem();


        public void RemoveItem();
        public bool CheckItem(ItemSO item);

    }
}

