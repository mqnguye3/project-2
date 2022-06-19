using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public interface IState
    {
        //IState StartState(BattleManager bm);
        IState DoState(BattleManager bm);
        //IState EndState(BattleManager bm);
    }

}
