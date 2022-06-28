using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class CounterState : IState
    {
        public IState DoState(BattleManager bm)
        {
            //TODO: Check to see if in range to counter, some skills cannot be countered ie, bomb
            if (bm.enemy_player.getCounter() > 0)
            {
                bm.enemy_anim.PlayAnimation(bm.enemy_player.getID() + "_hit", true);
                bm.enemy_player.decCounter();
            }
            return bm.runToState;

        }
    }

}
