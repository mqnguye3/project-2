using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Abilities
{
    [CreateAssetMenu(fileName = "Skill", menuName = "Skill/AttackSkill", order = 0)]
    public class AttackSkill : Skill
    {
        [SerializeField] protected string playerAttack;
        [SerializeField] protected string enemyHurt;
        [SerializeField] protected bool withWeapon;

    }

}