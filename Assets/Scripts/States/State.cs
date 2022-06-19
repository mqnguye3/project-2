using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    //base state
    public abstract class State
    {
        protected BattleManager bm;
        protected UnitController p1;
        protected UnitController p2;

        public State(BattleManager _bm, UnitController _p1, UnitController _p2)
        {
            this.bm = _bm;
            this.p1 = _p1;
            this.p2 = _p2;
        }
        public virtual IEnumerator Start()
        {
            yield break;
        }
        public virtual IEnumerator PlayAnimation()
        {
            yield break;
        }
        public virtual IEnumerator DoAction()
        {
            yield break;
        }

        public virtual IEnumerator Walk(Vector3 target)
        {
            yield break;
        }
    }

}
