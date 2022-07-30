using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Inventory
{
    [CreateAssetMenu(menuName = "Equipment/Outfit")]
    public class BattleOutfit : BattleEquipmentSO
    {
        [SerializeField] EquipmentType equipmentRestrictions;

        public EquipmentType getEquipmentRestrictions()
        {
            return equipmentRestrictions;
        }

        public bool canBeEquiped(EquipmentType equipmentType)
        {
            if (equipmentType != equipmentRestrictions) return false;
            return true;
        }
    }

}