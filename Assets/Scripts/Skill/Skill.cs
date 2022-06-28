using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Abilities
{
    public abstract class Skill : ScriptableObject
    {
        [SerializeField] protected AnimationClip animClip;
    }

}
