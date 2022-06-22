using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class BattleManager : MonoBehaviour
    {
        public UnitController p1;
        public UnitController p2;

        private IState currentState;

        public StartState startState = new StartState();
        public AttackState attackState = new AttackState();
        public CounterState counterState = new CounterState();
        public RunToState runToState = new RunToState();

        // Start is called before the first frame update
        private void OnEnable()
        {
            currentState = startState;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (currentState != null)
            {
                currentState = currentState.DoState(this);
            }
        }
    }

}
