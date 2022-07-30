using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Stats
{

    [CreateAssetMenu(menuName = "PlayerBattleInfo")]
    public class PlayerBattleInfo : ScriptableObject
    {
        [SerializeField] private AnimatorOverrideController outfitOverride = null;
        [SerializeField] private AnimatorOverrideController weaponOverride = null;



        public void SetOutfit(AnimatorOverrideController outfit)
        {
            if (outfit == null)
            {
                Debug.Log("PlayerBattleInfo.cs: Null Outfit");
                return;
            }
            outfitOverride = outfit;
        }

        public void SetWeapon(AnimatorOverrideController weapon)
        {
            if (weapon == null)
            {
                Debug.Log("PlayerBattleInfo.cs: Null Weapon");
                return;
            }
            weaponOverride = weapon;
        }
    }
}