using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jemmec.MultiDisplay
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField]
        private Vector3 _rotate;

        public Vector3 Rotate 
        {
            set => _rotate = value;
            get => _rotate;
        }

        void Update()
        {
            transform.localRotation *= Quaternion.Euler(_rotate * Time.deltaTime);
        }
    }
}
