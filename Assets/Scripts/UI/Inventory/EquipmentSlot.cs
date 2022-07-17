using System.Collections;
using System.Collections.Generic;
using PN.Equipment;
using UnityEngine;

namespace PN.UI
{
    public class EquipmentSlot : MonoBehaviour, IDroppables
    {
        [SerializeField] ItemIcon icon;
        [SerializeField] EquipmentType equipmentType;


        //TODO:
        //Set equipmentype and set checks to see if its the correct type before swapping/equipping them
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