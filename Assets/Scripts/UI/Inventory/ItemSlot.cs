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
        [SerializeField] ItemSO item;

        private void Awake()
        {
            SetUp();
        }

        private void SetUp()
        {
            if (item == null) return;

            AddItem(item);
        }
        public void AddItem(ItemSO item)
        {
            this.item = item;
            icon.SetItemIcon(item.GetSprite());
        }

        public ItemSO GetItem()
        {
            return item;
        }

        public void RemoveItem()
        {
            item = null;
            icon.SetItemIcon(null);
        }

        public bool CheckItem(ItemSO item)
        {
            if (item == null) return false;
            else return true;
        }
    }
}
