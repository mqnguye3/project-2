using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
TODO:
 - Make Seperate Animation Script
 - Make update method in ANimaton Script
 - Move Check for animation finish to new Animation Script
 - Make it more Generic (Currently only works with player 1)
 - Make new Namespace PN.Animation for script
 - include using namespace PN.Animation into this script
*/
public class BattleSystem : MonoBehaviour
{
    [SerializeField] private UnitController Player1, Player2;
    private enum State
    {
        ATTACK, ENEMYATTACK, IDLE
    }
    private enum AnimationState
    {
        PLAYING, FINISHED
    }

    private State currentState;
    private AnimationState animState;
    // Start is called before the first frame update
    void Start()
    {
        animState = AnimationState.FINISHED;
        BeginState();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.animFinish())
        {
            Player1.DoAnimation("1_idle");
        }
        switch (currentState)
        {
            case State.ATTACK:
                currentState = State.IDLE;
                ATTACK_PHASE(1, () =>
                {
                    currentState = State.ENEMYATTACK;
                });
                break;
            case State.ENEMYATTACK:
                currentState = State.IDLE;
                break;
        }


    }

    private void BeginState()
    {
        Player1.transform.position = new Vector3(-4.2f, -2.32f, 0);
        Player1.transform.Rotate(0, 180, 0);
        Player2.transform.position = new Vector3(4.2f, -2.32f, 0);

        Player1.setStartingPoisition(Player1.transform.position);
        Player2.setStartingPoisition(Player2.transform.position);
        Player1.setTargetPosition(new Vector3(Player2.transform.position.x + -1.2f, Player2.transform.position.y));
        Player1.setEnemy(Player2);
        Player2.setEnemy(Player1);
        Player1.setID(1);
        Player2.setID(2);
    }
    private void ATTACK_PHASE(int id, Action onComplete)
    {
        Player1.DoAnimation("1_hit");
        onComplete();
    }

}
