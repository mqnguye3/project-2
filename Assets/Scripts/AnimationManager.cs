using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Animation
{
    public class AnimationManager : MonoBehaviour
    {
        private Animator anim;
        private bool isPlaying = false;

        private string curr_anim;

        private void Start()
        {
            anim = GetComponent<Animator>();
            if (anim == null)
            {
                Debug.Log("null animator component");
            }
        }


        public void PlayAnimation(string new_anim)
        {
            if (!new_anim.Contains("idle"))
            {
                isPlaying = true;
            }
            if (isAlreadyPlaying(new_anim) == false)
            {
                anim.Play(new_anim);
            }

        }
        public void setAnimationDone()
        {
            isPlaying = false;
        }

        public bool isAnimPlaying()
        {
            return isPlaying;
        }

        private bool isAlreadyPlaying(string new_anim)
        {
            if (curr_anim == new_anim)
            {
                return true;
            }
            else
            {
                curr_anim = new_anim;
                return false;
            }

        }
    }

}
