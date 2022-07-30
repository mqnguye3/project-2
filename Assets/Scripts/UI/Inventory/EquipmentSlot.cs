using System;
using System.Collections;
using System.Collections.Generic;
using PN.Inventory;
using UnityEngine;

namespace PN.UI
{
    public class EquipmentSlot : MonoBehaviour, IDroppables
    {
        [SerializeField] ItemIcon icon;
        [SerializeField] EquipmentType equipmentType;
        private PlayerEquipment equipment;


        private void Awake()
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            equipment = player.GetComponent<PlayerEquipment>();
            equipment.updateEquipment += UpdateEquipmentUI;
        }

        private void UpdateEquipmentUI()
        {
            icon.SetItemIcon(equipment.GetEquipmentInSlot(equipmentType));
        }

        private void Start()
        {
            UpdateEquipmentUI();
        }
        public void AddItem(ItemSO item)
        {
            equipment.AddEquipmentToSlot(equipmentType, (EquipmentSO)item);
            icon.SetItemIcon(item);
        }

        public ItemSO GetItem()
        {

            return equipment.GetEquipmentInSlot(equipmentType);
        }

        public void RemoveItem()
        {
            equipment.RemoveEquipmentInSlot(equipmentType);
        }

        public bool CheckItem(ItemSO item)
        {
            if (item == null) return false;

            var equip = item as EquipmentSO;
            if (equip.GetEquipmentType() == equipmentType) return true;

            else return false;
        }
    }

}