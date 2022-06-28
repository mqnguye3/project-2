using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Battle
{
    public class StartState : IState
    {
        public IState DoState(BattleManager bm)
        {
            return bm.attackState;
        }
    }
}
