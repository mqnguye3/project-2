using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class AttackState : IState
    {
        public IState DoState(BattleManager bm)
        {
            AttackPhase(bm);
            return bm.attackState;
        }

        private void AttackPhase(BattleManager bm)
        {
            if (bm.p1.Run(bm.p1.getTargetPosition()))
            {
                //replace this with bm.p1.Attack(UnitController enemy)
                Attack(bm);
            }
        }

        private static void Attack(BattleManager bm)
        {
            bm.p1.SetAnimation("1_hit");
        }
    }
}
