using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PN.Equipment;

public class WeaponAnimation : MonoBehaviour
{
    [SerializeField] Weapon weapon_override;
    Animator weapon_anim;
    void Start()
    {
        weapon_anim = GetComponent<Animator>();

        weapon_override.EquipWeapon(weapon_anim);

    }


}
