using System.Collections;
using System.Collections.Generic;
using PN.Equipment;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PN.UI
{
    public class ItemSlot : MonoBehaviour, IDroppables
    {
        [SerializeField] ItemIcon icon = null;

        Inventory inventory;
        int index;


        public void SetUp(Inventory inventory, int index)
        {
            this.index = index;
            this.inventory = inventory;
            icon.SetItemIcon(inventory.GetItemSlot(index));

        }

        public void AddItem(ItemSO item)
        {
            inventory.AddItemToInventory(index, item);
        }

        public ItemSO GetItem()
        {
            return inventory.GetItemSlot(index);
        }

        public void RemoveItem()
        {
            inventory.RemoveItemFromInventory(index);
            icon.SetItemIcon(null);
        }

        public bool CheckItem(ItemSO item)
        {
            if (item == null) return false;
            else return true;
        }
    }
}
