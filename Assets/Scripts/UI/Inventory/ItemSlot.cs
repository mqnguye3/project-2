using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PN.UI
{
    public class ItemSlot : MonoBehaviour, IDroppables
    {

        [SerializeField] ItemIcon icon = null;

        public void AddItem(Sprite item)
        {
            icon.SetItemIcon(item);
        }

        public Sprite GetItem()
        {
            return icon.GetItemIcon();
        }

        public void RemoveItem()
        {
            icon.SetItemIcon(null);
        }
    }
}
