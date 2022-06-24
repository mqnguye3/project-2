using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class RunToState : IState
    {
        public IState DoState(BattleManager bm)
        {
            // if (bm.p1.transform.position != bm.p1.getTargetPosition())
            // {
            //     bm.p1.SetAnimation(bm.p1.getID() + "_run");
            //     bm.p1.transform.position = Vector3.MoveTowards(bm.p1.transform.position, bm.p1.getTargetPosition(), Time.deltaTime * 5);
            //     return this;
            // }
            // return nextState(bm);
            return this;

        }

        // private IState nextState(BattleManager bm)
        // {
        //     if (bm.p1.getStartingPosition() == bm.p1.getTargetPosition())
        //     {
        //         return bm.startState;
        //     }
        //     else
        //     {
        //         return bm.attackState;
        //     }
        // }
    }
}

