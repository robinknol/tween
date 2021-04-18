using System;
using UnityEngine;

namespace Script
{
    public class TweenTester : MonoBehaviour
    {
        public Vector3 targetPosition;
        public Vector3 targetRotation;
        public Vector3 targetScale;
        public float speed;

        public Type easeType;
        private TweenMachine _tweenMachine;

        private void Awake()
        {
            _tweenMachine = FindObjectOfType<TweenMachine>();
        }

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Space)) return;
            
            switch (easeType)
            {
                case Type.InSine:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInSine);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInSine);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInSine);
                    break;
                case Type.OutSine:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutSine);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutSine);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutSine);
                    break;
                case Type.InOutSine:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutSine);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutSine);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutSine);
                    break;
                case Type.InCubic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCubic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInCubic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInCubic);
                    break;
                case Type.OutCubic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutCubic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutCubic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutCubic);
                    break;
                case Type.InOutCubic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCubic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutCubic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInCubic);
                    break;
                case Type.InQuint:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuint);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInQuint);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInQuint);
                    break;
                case Type.OutQuint:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuint);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutQuint);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutQuint);
                    break;
                case Type.InOutQuint:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutQuint);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutQuint);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutQuint);
                    break;
                case Type.InCirc:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCirc);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInCirc);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInCirc);
                    break;
                case Type.OutCirc:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutCirc);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutCirc);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutCirc);
                    break;
                case Type.InOutCirc:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutCirc);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutCirc);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutCirc);
                    break;
                case Type.InElastic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInElastic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInElastic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInElastic);
                    break;
                case Type.OutElastic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutElastic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutElastic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutElastic);
                    break;
                case Type.InOutElastic:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutElastic);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutElastic);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutElastic);
                    break;
                case Type.InQuad:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuad);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInQuad);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInQuad);
                    break;
                case Type.OutQuad:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuad);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutQuad);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutQuad);
                    break;
                case Type.InOutQuad:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutQuad);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutQuad);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutQuad);
                    break;
                case Type.InQuart:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuart);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInQuart);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInQuart);
                    break;
                case Type.OutQuart:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutQuart);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutQuart);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutQuart);
                    break;
                case Type.InOutQuart:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutQuart);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutQuart);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutQuart);
                    break;
                case Type.InExpo:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInExpo);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInExpo);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInExpo);
                    break;
                case Type.OutExpo:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutExpo);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutExpo);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutExpo);
                    break;
                case Type.InOutExpo:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutExpo);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutExpo);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutExpo);
                    break;
                case Type.InBack:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInBack);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInBack);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInBack);
                    break;
                case Type.OutBack:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutBack);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutBack);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutBack);
                    break;
                case Type.InOutBack:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutBack);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutBack);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutBack);
                    break;
                case Type.InBounce:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInBounce);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInBounce);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInBounce);
                    break;
                case Type.OutBounce:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseOutBounce);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseOutBounce);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseOutBounce);
                    break;
                case Type.InOutBounce:
                    _tweenMachine.EaseMoveGameObject(gameObject, targetPosition, speed, Easings.EaseInOutBounce);
                    _tweenMachine.EaseRotateGameObject(gameObject, targetRotation, speed, Easings.EaseInOutBounce);
                    _tweenMachine.EaseScaleGameObject(gameObject, targetScale, speed, Easings.EaseInOutBounce);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}