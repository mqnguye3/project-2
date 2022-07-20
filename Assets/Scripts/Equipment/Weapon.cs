using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Equipment
{

    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/New Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] EquipmentType weaponType;
        [SerializeField] int weaponId;
        [SerializeField] AnimatorOverrideController weapon_override;
        [SerializeField] Sprite icon;
        [SerializeField] int height;
        [SerializeField] int width;

        public void EquipWeapon(Animator anim)
        {
            anim.runtimeAnimatorController = weapon_override;
        }

        public Sprite getIcon()
        {
            return icon;
        }
    }
}