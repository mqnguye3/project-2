using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Weapons
{

    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/New Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] WeaponType weaponType;
        [SerializeField] int weaponId;
        [SerializeField] AnimatorOverrideController weapon_override;

        public void EquipWeapon(Animator anim)
        {
            anim.runtimeAnimatorController = weapon_override;
        }
    }
}