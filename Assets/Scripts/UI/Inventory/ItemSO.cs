using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Equipment
{

    [CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item", order = 0)]
    public class ItemSO : ScriptableObject
    {
        [SerializeField] int itemID;
        [SerializeField] string itemName;
        [SerializeField] string itemDestription;
        [SerializeField] Sprite itemIcon;

        public Sprite GetSprite()
        {
            return itemIcon;
        }

    }
}

