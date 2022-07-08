using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Stats
{
    public class ResourceBar : MonoBehaviour
    {
        [SerializeField] Stats stats;
        [SerializeField] RectTransform scaler = null;

        void Update()
        {
            updateHP();
        }


        private void updateHP()
        {
            float newHP = stats.getHealthPercent();
            scaler.localScale = new Vector3(newHP, 1, 1);
        }
    }

}