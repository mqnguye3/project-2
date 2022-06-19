using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class AttackState1 : State
    {
        public AttackState1(BattleManager bm, UnitController p1, UnitController p2) : base(bm, p1, p2) { }

        public override IEnumerator Start()
        {

            bm.WalkToDest(p1.getTargetPosition());
            yield return null;
            bm.DoUnitAction();
        }

        public override IEnumerator DoAction()
        {
            p1.SetAnimation("Attack");
            p1.SetAnimation("Idle");
            bm.WalkToDest(p1.getStartingPosition());
            yield break;

        }

        public override IEnumerator Walk(Vector3 target)
        {
            p1.SetAnimation("Run");
            while (p1.transform.position != target)
            {
                p1.transform.position = Vector3.MoveTowards(p1.transform.position, target, Time.deltaTime);
                yield return null;
            }
            Debug.Log("done");
            yield return null;

        }



    }
}