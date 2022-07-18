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
        private EquipmentSO equipment;


        //TODO:
        //Set equipmentype and set checks to see if its the correct type before swapping/equipping them
        public void AddItem(ItemSO item)
        {
            equipment = item as EquipmentSO;
            icon.SetItemIcon(item.GetSprite());
        }

        public ItemSO GetItem()
        {

            return equipment;
        }

        public void RemoveItem()
        {
            equipment = null;
            icon.SetItemIcon(null);
        }

        public bool CheckItem(ItemSO item)
        {
            if (item == null) return false;

            var equip = item as EquipmentSO;
            if (equip.GetEquipmentType() == equipmentType) return true;

            return false;
        }
    }

}