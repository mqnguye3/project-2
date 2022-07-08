using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Stats
{
    public class Stats : MonoBehaviour
    {
        [Range(1, 7)]
        [SerializeField] int level;
        int health = 10;
        int chakra;
        [SerializeField] BaseStats stats;


        private void Start()
        {
            health = stats.getHealth();
            chakra = stats.getChakra();
        }

        public int getHealth()
        {
            return health;
        }

        public int getChakra()
        {
            return chakra;
        }

        public float getHealthPercent()
        {
            return (float)health / (float)stats.getHealth();
        }

        public void takeDamage(int dmg)
        {
            health -= dmg;

        }
    }

}