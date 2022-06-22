using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class AttackState : IState
    {
        public IState DoState(BattleManager bm)
        {
            Attack(bm);
            if (bm.p1.isPlaying() == false)
            {
                return bm.counterState;
            }
            else
            {
                return this;
            }
        }

        private void Attack(BattleManager bm)
        {
            bm.p1.SetAnimation("1_hit");
        }

        private void SetDestination(BattleManager bm)
        {
            bm.p1.setTargetPosition(bm.p1.getStartingPosition());
            bm.p1.transform.Rotate(0, -180, 0);
        }
    }
}
