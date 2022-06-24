using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PN.Animation;

/*
<summary>

Current Architecture: 
-> Animation is played
-> isPlaying is set to true in AnimationManager.PlayAnimation()
-> on Frame that attack makes contact AnimationEvent AttackingPlayer.AttackConnected() is called
-> calls EnemyPlayer.Hurt()
-> on Last Frame of Attack Animation AnimationEvent csalls AnimationManager.setAnimationDone() -> isPlay = false
-> BattleSystem.Update() checks to see if isPlaying is false to reset both unit to default idle state;

**AttackingPlayer = Player1 or Player2 turn
** EnemyPlayer = Player1.enemy or Player2.enemy

</summary>

TODO: Countering Next

*/
public class BattleSystem : MonoBehaviour
{
    [SerializeField] private UnitController Player1, Player2;
    [SerializeField] private AnimationManager Anim1, Anim2;

    private UnitController curr_player;
    private AnimationManager curr_anim;
    private enum State
    {
        ATTACK, BUSY,
        RUN, END
    }


    private State currentState;
    // Start is called before the first frame update
    void Start()
    {
        BeginState();
    }

    // Update is called once per frame
    void Update()
    {
        if (curr_anim.isAnimPlaying() == false)
        {
            ResetState();
        }
        else return;
        switch (currentState)
        {
            case State.ATTACK:
                currentState = State.BUSY;
                if (curr_player.transform.position != curr_player.getTargetPosition())
                {
                    currentState = State.RUN;
                    return;
                }

                ATTACK_PHASE(curr_player.getID(), () =>
                {
                    currentState = State.RUN;
                });
                break;

            case State.RUN:
                currentState = State.BUSY;
                if (curr_player.transform.position != curr_player.getStartingPosition())
                {
                    curr_player.setTargetPosition(curr_player.getStartingPosition());
                }
                StartCoroutine(RunTo());
                break;
        }


    }

    private void BeginState()
    {
        NewTurn();
        currentState = State.ATTACK;

    }
    private void NewTurn()
    {
        Player1.transform.position = new Vector3(-4.2f, -2.32f, 0);
        Player1.transform.rotation = Quaternion.Euler(0, 180, 0);

        Player2.transform.position = new Vector3(4.2f, -2.32f, 0);
        Player2.transform.rotation = Quaternion.Euler(0, 0, 0);


        Player1.setStartingPoisition(Player1.transform.position);
        Player2.setStartingPoisition(Player2.transform.position);

        Player1.setTargetPosition(new Vector3(Player2.transform.position.x + -1.2f, Player2.transform.position.y));
        Player2.setTargetPosition(new Vector3(Player1.transform.position.x + 1.2f, Player1.transform.position.y));

        Player1.setEnemy(Player2);
        Player2.setEnemy(Player1);

        Player1.setID(1);
        Player2.setID(2);

        Anim1.setAnimationDone();
        Anim2.setAnimationDone();

        SetCurrentPlayer();
    }

    private void ATTACK_PHASE(int id, Action onComplete)
    {
        curr_anim.PlayAnimation(id + "_hit");
        onComplete();
    }

    private void Counter_Phase()
    {

    }

    private void ResetState()
    {
        Anim1.PlayAnimation("1_idle");
        Anim2.PlayAnimation("2_idle");
    }

    private void SetCurrentPlayer()
    {
        if (curr_player == Player1 || curr_player == null)
        {
            curr_player = Player2;
            curr_anim = Anim2;
        }
        else
        {
            curr_player = Player1;
            curr_anim = Anim1;

        }
    }

    private IEnumerator RunTo()
    {
        curr_player.transform.right = curr_player.transform.position - curr_player.getTargetPosition();
        curr_anim.PlayAnimation(curr_player.getID() + "_run");
        while (curr_player.transform.position != curr_player.getTargetPosition())
        {
            curr_player.transform.position = Vector3.MoveTowards(curr_player.transform.position, curr_player.getTargetPosition(), Time.deltaTime * 5);
            yield return null;
        }

        ResetState();
        curr_anim.setAnimationDone();

        if (curr_player.getStartingPosition() == curr_player.transform.position)
        {
            BeginState();
        }
        else
        {
            currentState = State.ATTACK;
        }

    }

}
