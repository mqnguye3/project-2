using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Inventory
{
    public abstract class EquipmentSO : ItemSO
    {
        [SerializeField] EquipmentType equipmentType;

        public EquipmentType GetEquipmentType()
        {
            return equipmentType;
        }
    }
}

