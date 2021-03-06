using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PN.Animation
{
    public class AnimationManager : MonoBehaviour
    {
        private Animator anim;
        [SerializeField] private Animator wep_anim;
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


        public void PlayAnimation(int id, string new_anim)
        {
            if (isAlreadyPlaying(new_anim) == false)
            {
                anim.Play(id + new_anim);
                wep_anim.Play(new_anim);
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

        public void PlayAnimation(int id, string attack_anim, bool isPlaying)
        {
            this.isPlaying = isPlaying;
            if (isAlreadyPlaying(attack_anim) == false)
            {
                anim.Play(id + attack_anim);
                wep_anim.Play(attack_anim);
            }
        }
    }

}
