using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Equipment
{
    public class Inventory : MonoBehaviour
    {

        public event Action updateInventory;
        private int size = 35;

        [SerializeField] ItemSO[] items;

        [SerializeField] ItemSO[] temp_items;

        private void Awake()
        {
            items = new ItemSO[size];

            for (int i = 0; i < temp_items.Length; i++)
            {
                items[i] = temp_items[i];
            }
        }
        public static Inventory GetPlayerInventory()
        {
            var inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
            if (inventory != null)
            {
                return inventory;
            }

            else
            {
                Debug.LogError("No inventory found on player");
                return null;
            }
        }

        public ItemSO GetItemSlot(int index)
        {
            return items[index];
        }

        public int GetSize()
        {
            return size;
        }

        public void AddItemToInventory(int index, ItemSO item)
        {
            if (items[index] != null)
            {
                return;
            }

            items[index] = item;
            if (updateInventory != null)
            {
                updateInventory();
            }
        }

        public void RemoveItemFromInventory(int index)
        {
            items[index] = null;
            if (updateInventory != null)
            {
                updateInventory();
            }
        }
    }

}