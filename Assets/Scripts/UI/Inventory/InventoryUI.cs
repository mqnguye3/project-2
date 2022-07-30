using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PN.Inventory;
using System;

namespace PN.UI
{
    public class InventoryUI : MonoBehaviour
    {
        private PlayerInventory playerInventory;
        [SerializeField] ItemSlot itemSlotPrefab;

        private void Awake()
        {
            playerInventory = PlayerInventory.GetPlayerInventory();
            playerInventory.updateInventory += UpdateInventoryUI;
        }

        private void Start()
        {
            UpdateInventoryUI();
        }

        private void UpdateInventoryUI()
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }

            for (int i = 0; i < playerInventory.GetSize(); i++)
            {
                var itemSlot = Instantiate(itemSlotPrefab, transform);
                itemSlot.SetUp(playerInventory, i);
            }
        }
    }

}