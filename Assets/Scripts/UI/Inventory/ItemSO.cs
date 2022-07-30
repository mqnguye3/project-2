using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Inventory
{
    public abstract class ItemSO : ScriptableObject
    {
        [SerializeField] int itemID;
        [SerializeField] string itemName;
        // [SerializeField] string itemDestription;
        [SerializeField] Sprite itemIcon;

        public Sprite GetSprite()
        {
            return itemIcon;
        }

    }
}

