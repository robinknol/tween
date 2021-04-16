using System;
using UnityEngine;

namespace Script
{
    public class Tween
    {
        public GameObject GameObject;
        
        public Vector3 Start;
        public Vector3 Target;
        public Vector3 Direction;
        
        public float Speed;
        public float Percent;
        
        public Func<float, float> Method;

        public Action OnTweenUpdate;
        public void EaseUpdateTweenMove(float dt)
        {
            Percent += dt / Speed;

            if (Percent < 1)
            {
                var easeStep = Method(Percent);
                GameObject.transform.position = Start + (Direction * easeStep);
                if (OnTweenUpdate != null)
                    OnTweenUpdate();
            }
            else
            {
                GameObject.transform.position = Target;
            }
        }
        public void EaseUpdateTweenRotation(float dt)
        {
            Percent += dt / Speed;

            if (Percent < 1)
            {
                var easeStep = Method(Percent);
                GameObject.transform.rotation = Quaternion.Euler(Start + (Direction * easeStep));
                if (OnTweenUpdate != null)
                    OnTweenUpdate();
            }
            else
            {
                GameObject.transform.rotation = Quaternion.Euler(Target);
            }
        }
        public void EaseUpdateTweenScale(float dt)
        {
            Percent += dt / Speed;

            if (Percent < 1)
            {
                var easeStep = Method(Percent);
                GameObject.transform.localScale = Start + (Direction * easeStep);
                if (OnTweenUpdate != null)
                    OnTweenUpdate();
            }
            else
            {
                GameObject.transform.localScale = Target;
            }
        }
    }
}