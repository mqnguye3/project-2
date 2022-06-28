using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PN.Battle
{
    public class RunToState : IState
    {
        public IState DoState(BattleManager bm)
        {
            if (bm.curr_player.transform.position != bm.curr_player.getStartingPosition())
            {
                bm.StartCoroutine(RunTo(bm, bm.curr_player.getStartingPosition()));
                return bm.endState;
            }
            else
            {
                bm.StartCoroutine(RunTo(bm, bm.curr_player.getTargetPosition()));
                return bm.attackState;
            }




        }

        private IEnumerator RunTo(BattleManager bm, Vector3 dest)
        {
            //get what direction to run face when running back/forth
            bm.curr_player.transform.right = bm.curr_player.transform.position - dest;


            bm.curr_anim.PlayAnimation(bm.curr_player.getID() + "_run", true);
            while (bm.curr_player.transform.position != dest)
            {
                bm.curr_player.transform.position = Vector3.MoveTowards(bm.curr_player.transform.position, dest, Time.deltaTime * 5);
                yield return null;
            }

            bm.curr_anim.setAnimationDone();
            bm.ResetState();

        }
    }
}

