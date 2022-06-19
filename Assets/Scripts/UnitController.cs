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



    private void Awake()
    {
        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.Log("Unit Controller: animator null ref");
        }

    }

    public void setEnemy(UnitController e)
    {
        enemy = e;
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

    /* TODO: 
        Buff,
        Death,
        Win,
        Lose
    */

    public void Attack()
    {
        enemy.Hurt();
    }


    public void Hurt()
    {
        SetAnimation(id + "_hurt");
    }

    private void ReturnToIdle()
    {
        SetAnimation(id + "_idle");
    }

    public bool Run(Vector3 target)
    {
        if (transform.position != target_pos)
        {
            SetAnimation(id + "_run");
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 5);
            return false;
        }
        return true;
    }

    public void setID(int i)
    {
        id = i;
    }

}
