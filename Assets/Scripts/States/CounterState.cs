using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class CounterState : IState
    {
        public IState DoState(BattleManager bm)
        {
            if (bm.p2.canCounter())
            {
                Attack(bm);

            }
            if (bm.p2.isPlaying() == false)
            {
                SetDestination(bm);
                return bm.runToState;
            }
            else
            {
                return this;
            }


        }

        private void Attack(BattleManager bm)
        {
            bm.p2.SetAnimation("2_hit");
        }

        private void SetDestination(BattleManager bm)
        {
            bm.p1.setTargetPosition(bm.p1.getStartingPosition());
            bm.p1.transform.Rotate(0, -180, 0);
        }
    }

}
