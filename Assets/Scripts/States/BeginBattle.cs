using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class BeginBattle : State
    {
        public BeginBattle(BattleManager bm, UnitController p1, UnitController p2) : base(bm, p1, p2) { }
        public override IEnumerator Start()
        {
            p1.transform.position = new Vector3(-4.2f, -2.32f, 0);
            p1.transform.Rotate(0, 180, 0);
            p2.transform.position = new Vector3(4.2f, -2.32f, 0);

            p1.setStartingPoisition(p1.transform.position);
            p2.setStartingPoisition(p2.transform.position);
            p1.setTargetPosition(new Vector3(p2.transform.position.x + -1.2f, p2.transform.position.y));
            yield return null;
            bm.SetState(new AttackState1(bm, p1, p2));
            bm.p1.SetAnimation("p1_idle");
            bm.p2.SetAnimation("p2_idle");
        }
    }

}
