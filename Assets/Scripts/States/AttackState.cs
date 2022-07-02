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
                bm.curr_anim.PlayAnimation(bm.curr_player.getID(), "_hit", true);
                return bm.counterState;
            }

        }
    }
}
