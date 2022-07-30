using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Inventory
{

    [CreateAssetMenu(fileName = "Item", menuName = "Inventory/Weapon", order = 0)]
    public class BattleEquipmentSO : EquipmentSO
    {
        /*
        TODO:
        replace WEapon.cs with this SO and replace all instances with this for the battle
        */
        [SerializeField] AnimatorOverrideController equipmentOverride;

        public void EquipOverrideAnimator(Animator anim)
        {
            anim.runtimeAnimatorController = equipmentOverride;
        }

        public void SetEquipment(AnimatorOverrideController animOverride)
        {
            equipmentOverride = animOverride;
        }

        public AnimatorOverrideController getEquipmentOverride()
        {
            return equipmentOverride;
        }


    }
}

