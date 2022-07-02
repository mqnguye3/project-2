using UnityEngine;
using PN.Animation;
using PN.Abilities;
using System.Collections.Generic;

public class UnitController : MonoBehaviour
{
    private AnimationManager anim;
    private Vector3 starting_pos;
    private UnitController enemy;
    private Vector3 target_pos;
    private string current_anim;
    private int id;

    [SerializeField] List<AttackSkill> skills = new List<AttackSkill>();

    private int counter = 3;

    private void Awake()
    {
        anim = GetComponent<AnimationManager>();
        if (anim == null)
        {
            Debug.Log("Unit Controller: animator null ref");
        }

    }

    public void setEnemy(UnitController target)
    {
        enemy = target;
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
        anim.PlayAnimation(id, "_hurt");
    }

    public void setID(int i)
    {
        id = i;
    }
    public int getID()
    {
        return id;
    }

    public int getCounter()
    {
        return counter;
    }

    public void decCounter()
    {
        counter--;
    }

    public AttackSkill getAbility()
    {
        return skills[0];
    }
}
