using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public abstract class BattleSM : MonoBehaviour
    {
        protected State State;

        public void SetState(State state)
        {
            State = state;
            StartCoroutine(State.Start());
        }

        public void PlayUnitAnimation()
        {
            StartCoroutine(State.PlayAnimation());
        }
        public void DoUnitAction()
        {
            StartCoroutine(State.DoAction());
        }

        public void WalkToDest(Vector3 target)
        {
            StartCoroutine(State.Walk(target));
        }

    }
}

