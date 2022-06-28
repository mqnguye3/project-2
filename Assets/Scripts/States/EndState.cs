using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class EndState : IState
    {
        public IState DoState(BattleManager bm)
        {
            bm.SetUp();
            return bm.startState;
        }
    }

}
