using UnityEngine;
using System;

namespace Script.Tweens
{
    public class TweenRotation : Tween
    {
        public TweenRotation(GameObject objectToInteract, Vector3 targetPos, float speed, Func<float, float> method)
        {
            GameObject = objectToInteract;
            Target = targetPos;
            Speed = speed;

            Start = GameObject.transform.rotation.eulerAngles;
            Direction = Target - Start;
            Percent = 0;

            Method = method;
        }
    }
}