using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PN.Animation;

namespace PN.Battle
{
    public class BattleManager : MonoBehaviour
    {
        public UnitController player1, player2;
        [SerializeField] private AnimationManager anim1, anim2;

        public UnitController curr_player { get; private set; }
        public AnimationManager curr_anim { get; private set; }

        public UnitController enemy_player { get; private set; }
        public AnimationManager enemy_anim { get; private set; }


        private IState currentState;

        public StartState startState = new StartState();
        public AttackState attackState = new AttackState();
        public CounterState counterState = new CounterState();
        public RunToState runToState = new RunToState();
        public EndState endState = new EndState();

        // Start is called before the first frame update
        private void Start()
        {
            currentState = startState;
            SetUp();
        }

        // Update is called once per frame
        void Update()
        {
            if (enemy_anim.isAnimPlaying()) return;
            if (curr_anim.isAnimPlaying()) return;
            ResetState();
            currentState = currentState.DoState(this);
        }

        public void SetCurrentPlayer()
        {
            if (curr_player == player2 || curr_player == null)
            {
                curr_player = player1;
                curr_anim = anim1;


                enemy_player = player2;
                enemy_anim = anim2;
            }
            else
            {
                curr_player = player2;
                curr_anim = anim2;

                enemy_player = player1;
                enemy_anim = anim1;
            }
        }

        public void ResetState()
        {
            anim1.PlayAnimation(player1.getID() + "_idle");
            anim2.PlayAnimation(player2.getID() + "_idle");
        }


        public void SetUp()
        {
            player1.transform.position = new Vector3(-4.2f, -2.32f, 0);
            player1.transform.rotation = Quaternion.Euler(0, 180, 0);

            player2.transform.position = new Vector3(4.2f, -2.32f, 0);
            player2.transform.rotation = Quaternion.Euler(0, 0, 0);


            player1.setStartingPoisition(player1.transform.position);
            player2.setStartingPoisition(player2.transform.position);

            player1.setTargetPosition(new Vector3(player2.transform.position.x + -1.2f, player2.transform.position.y));
            player2.setTargetPosition(new Vector3(player1.transform.position.x + 1.2f, player1.transform.position.y));

            player1.setEnemy(player2);
            player2.setEnemy(player1);

            player1.setID(1);
            player2.setID(2);

            anim1.setAnimationDone();
            anim2.setAnimationDone();

            SetCurrentPlayer();
        }
    }

}
