using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Abilities
{
    public abstract class Skill : ScriptableObject
    {
        [SerializeField] protected float procRate;
        [SerializeField] protected int skillID;
        [SerializeField] protected SkillType type;
    }

}
