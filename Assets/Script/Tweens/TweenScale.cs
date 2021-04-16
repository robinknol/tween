using UnityEngine;
using System;

namespace Script.Tweens
{
    public class TweenScale : Tween
    {
        public TweenScale(GameObject objectToInteract, Vector3 targetPos, float speed, Func<float, float> method)
        {
            GameObject = objectToInteract;
            Target = targetPos;
            Speed = speed;

            Start = GameObject.transform.localScale;
            Direction = Target - Start;
            Percent = 0;

            Method = method;
        }
    }
}