using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class AttackState : IState
    {
        public IState DoState(BattleManager bm)
        {
            if (bm.curr_player.getTargetPosition() != bm.curr_player.transform.position)
            {
                return bm.runToState;
            }
            else
            {
                /*
                TODO:
                1. grab skill arr
                2. pass in attack skill.animation
                3. do dmg
                */
                bm.curr_anim.PlayAnimation(bm.curr_player.getID(), bm.curr_player.getAbility().playerAttack, true);
                return bm.counterState;
            }

        }
    }
}
