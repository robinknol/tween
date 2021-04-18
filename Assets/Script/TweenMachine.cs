using System;
using System.Collections.Generic;
using UnityEngine;
using Script.Tweens;

namespace Script
{
    public class TweenMachine : MonoBehaviour
    {
        private readonly List<TweenMove> _moveTween = new List<TweenMove>();
        private readonly List<TweenScale> _scaleTween = new List<TweenScale>();
        private readonly List<TweenRotation> _rotationTween = new List<TweenRotation>();
        private void Update()
        {
            if (_moveTween.Count < 1);
            {
                foreach (var tween in _moveTween)
                {
                    tween.EaseUpdateTweenMove(Time.deltaTime);
                }
            }
            
            if (_rotationTween.Count < 1);
            {
                foreach (var tween in _rotationTween)
                {
                    tween.EaseUpdateTweenRotation(Time.deltaTime);
                }
            }

            if (_scaleTween.Count < 1);
            {
                foreach (var tween in _scaleTween)
                {
                    tween.EaseUpdateTweenScale(Time.deltaTime);
                }
            }
        }

        public void EaseMoveGameObject(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> easeMethod)
        {
            var newTween = new TweenMove(objectToMove, targetPosition, speed, easeMethod);
            _moveTween.Add(newTween);
        }

        public void EaseRotateGameObject(GameObject objectToRotate, Vector3 targetRotation, float speed, Func<float, float> easeMethod)
        {
            var newTween = new TweenRotation(objectToRotate, targetRotation, speed, easeMethod);
            _rotationTween.Add(newTween);
        }

        public void EaseScaleGameObject(GameObject objectToScale, Vector3 targetScale, float speed, Func<float, float> easeMethod)
        {
            var newTween = new TweenScale(objectToScale, targetScale, speed, easeMethod);
            _scaleTween.Add(newTween);
        }
    }
}