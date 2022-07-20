using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Equipment
{

    [CreateAssetMenu(fileName = "Item", menuName = "Inventory/Weapon", order = 0)]
    public class WeaponSO : EquipmentSO
    {
        /*
        TODO:
        replace WEapon.cs with this SO and replace all instances with this for the battle
        */
        [SerializeField] AnimatorOverrideController overrideController;


        public void EquipWeapon(Animator anim)
        {
            anim.runtimeAnimatorController = overrideController;
        }
    }
}

