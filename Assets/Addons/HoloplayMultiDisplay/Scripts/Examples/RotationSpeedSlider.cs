using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jemmec.MultiDisplay
{
    public class RotationSpeedSlider : MonoBehaviour
    {
        [SerializeField]
        private UnityEngine.UI.Slider _rotationSlider;

        [SerializeField]
        private Rotator _rotator;

        void Start()
        {
            _rotationSlider.onValueChanged.AddListener((val) =>
            {
                _rotator.Rotate = new Vector3(0f, val, 0f);
            });
        }
    }
}
