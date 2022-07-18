using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Equipment
{

    [CreateAssetMenu(fileName = "Equipment", menuName = "Inventory/Equipment", order = 0)]
    public class EquipmentSO : ItemSO
    {
        [SerializeField] EquipmentType equipmentType;

        public EquipmentType GetEquipmentType()
        {
            return equipmentType;
        }
    }
}

