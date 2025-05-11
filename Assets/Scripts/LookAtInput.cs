using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
    public class LookAtInput : MonoBehaviour
    {
        public StarterAssetsInputs _input; // StarterAssetsInputsクラスのインスタンスを格納する変数
        public float TopClamp = 70.0f;
        public float BottomClamp = -30.0f;
        public Transform boneToRotate;
        private float _TargetYaw;
        private float _TargetPitch;
        private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
        {
            if (lfAngle < -360f) lfAngle += 360f;
            if (lfAngle > 360f) lfAngle -= 360f;
            return Mathf.Clamp(lfAngle, lfMin, lfMax);
        }


            void Update()
        {
            _TargetYaw += _input.look.x;
            _TargetPitch += _input.look.y;
            _TargetYaw = ClampAngle(_TargetYaw, float.MinValue, float.MaxValue);
            _TargetPitch = ClampAngle(_TargetPitch, BottomClamp, TopClamp);
            transform.rotation = Quaternion.Euler(0.0f, _TargetYaw, 0.0f);
            if (boneToRotate != null)
            {
                boneToRotate.rotation = Quaternion.Euler(-_TargetPitch, -180+_TargetYaw, 0.0f);
            }
        }

    }
}

