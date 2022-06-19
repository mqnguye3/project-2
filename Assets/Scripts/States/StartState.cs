using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Battle
{
    public class StartState : IState
    {
        public IState DoState(BattleManager bm)
        {
            bm.p1.transform.position = new Vector3(-4.2f, -2.32f, 0);
            bm.p1.transform.Rotate(0, 180, 0);
            bm.p2.transform.position = new Vector3(4.2f, -2.32f, 0);

            bm.p1.setStartingPoisition(bm.p1.transform.position);
            bm.p2.setStartingPoisition(bm.p2.transform.position);
            bm.p1.setTargetPosition(new Vector3(bm.p2.transform.position.x + -1.2f, bm.p2.transform.position.y));
            bm.p1.setEnemy(bm.p2);
            bm.p2.setEnemy(bm.p1);
            bm.p1.setID(1);
            bm.p2.setID(2);
            return new AttackState().DoState(bm);
        }
    }
}
