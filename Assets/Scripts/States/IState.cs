using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public interface IState
    {   
        IState DoState(BattleManager bm);
    }

}
