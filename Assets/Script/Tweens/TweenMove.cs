using UnityEngine;
using System;

namespace Script.Tweens
{
    public class TweenMove : Tween
    {
        public TweenMove(GameObject objectToInteract, Vector3 targetPos, float speed, Func<float, float> method)
        {
            GameObject = objectToInteract;
            Target = targetPos;
            Speed = speed;

            Start = GameObject.transform.position;
            Direction = Target - Start;
            Percent = 0;

            Method = method;
        }
    }
}