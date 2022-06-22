using System;
using System.Collections;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    private Animator anim;
    private Vector3 starting_pos;
    private UnitController enemy;
    private Vector3 target_pos;
    private string current_anim;
    private int id;

    private int counter = 3;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.Log("Unit Controller: animator null ref");
        }

    }

    public void setEnemy(UnitController target)
    {
        enemy = target;
    }


    public void SetAnimation(string new_anim)
    {
        if (current_anim == new_anim) return;

        anim.Play(new_anim);

        current_anim = new_anim;
    }

    public void setStartingPoisition(Vector3 pos)
    {
        starting_pos = pos;
    }

    public Vector3 getStartingPosition()
    {
        return starting_pos;
    }

    public void setTargetPosition(Vector3 pos)
    {
        target_pos = pos;
    }

    public Vector3 getTargetPosition()
    {
        return target_pos;
    }


    // animation event: frame that attack connects with enemy
    public void AttackConnect()
    {
        enemy.Hurt();
    }


    public void Hurt()
    {
        SetAnimation(id + "_hurt");
    }


    //animation event: last frame of any attack anim
    private void ReturnToIdle()
    {
        SetAnimation(id + "_idle");
    }

    public void setID(int i)
    {
        id = i;
    }
    public int getID()
    {
        return id;
    }


    public bool isPlaying()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(id + "_idle"))
            return false;
        else
            return true;
    }
    public void decCounter()
    {

        counter--;
    }

    public bool canCounter()
    {
        if (counter > 0)
        {
            Debug.Log(counter);
            return true;
        }
        else
        {
            return false;
        }
    }


    public void DoAnimation(string trigger)
    {
        anim.Play(trigger);
    }

    public bool animFinish()
    {
        // if (anim.GetCurrentAnimatorStateInfo(0).IsName(id + "_idle")) return true;
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("1_hit") &&
           anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return false;
        else
            return true;
    }
}
