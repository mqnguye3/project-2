using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Stats
{
    [CreateAssetMenu(fileName = "Stats", menuName = "Stats", order = 0)]
    public class BaseStats : ScriptableObject
    {
        [SerializeField] int hp;
        [SerializeField] int chakra;
        [SerializeField] int attack;
        [SerializeField] int defense;

        public int getHealth()
        {
            return hp;
        }
        public int getChakra()
        {
            return chakra;
        }
        public int getAttack()
        {
            return attack;
        }

        public int getDefense()
        {
            return defense;
        }
    }

}