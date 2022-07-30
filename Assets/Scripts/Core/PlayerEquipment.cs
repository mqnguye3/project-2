using System;
using System.Collections;
using System.Collections.Generic;
using PN.Stats;
using UnityEngine;

namespace PN.Inventory
{
    public class PlayerEquipment : MonoBehaviour
    {

        [SerializeField] PlayerBattleInfo playerBattleInfo;
        Dictionary<EquipmentType, EquipmentSO> equipped = new Dictionary<EquipmentType, EquipmentSO>();

        public event Action updateEquipment;

        public EquipmentSO GetEquipmentInSlot(EquipmentType equipmentType)
        {
            if (!equipped.ContainsKey(equipmentType)) return null;
            return equipped[equipmentType];
        }

        public void AddEquipmentToSlot(EquipmentType equipmentType, EquipmentSO equipment)
        {
            Debug.Assert(equipment.GetEquipmentType() == equipmentType);
            equipped[equipmentType] = equipment;
            if (updateEquipment != null)
            {
                updateEquipment();
            }

            if (equipmentType == EquipmentType.Outfit)
            {
                var battleEQ = equipment as BattleEquipmentSO;
                playerBattleInfo.SetOutfit(battleEQ.getEquipmentOverride());
            }
            if (equipmentType == EquipmentType.Sharp || equipmentType == EquipmentType.Blunt || equipmentType == EquipmentType.Claw)
            {
                var battleEQ = equipment as BattleEquipmentSO;
                playerBattleInfo.SetWeapon(battleEQ.getEquipmentOverride());
            }
        }

        public void RemoveEquipmentInSlot(EquipmentType equipmentType)
        {
            equipped.Remove(equipmentType);
            if (updateEquipment != null)
            {
                updateEquipment();
            }
        }


    }



}