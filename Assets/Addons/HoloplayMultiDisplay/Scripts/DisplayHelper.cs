using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LookingGlass;

namespace Jemmec.MultiDisplay
{
    public enum DisplayHelperType
    {
        UserInterface,
        UnityCamera,
        HoloplayCapture
    }

    /// <summary>
    /// Attach to each individual display so they can be updated when the display number
    /// changes either in runtime or editor
    /// </summary>
    public class DisplayHelper : MonoBehaviour
    {

        [SerializeField]
        private DisplayHelperType _type;

        public DisplayHelperType Type
        {
            get => _type;
            set => _type = value;
        }

        [SerializeField]
        private Canvas _canvas;

        [SerializeField]
        private Camera _camera;

        [SerializeField]
        private Holoplay _holoplay;

        public void UpdateDisplayNumber(int number)
        {
            //Because Holoplay only supports 8 displays *shrug*
            if (number < 0 || number > 8) return;
            if (_canvas)
                _canvas.targetDisplay = number;
            if (_camera)
                _camera.targetDisplay = number;
            if (_holoplay)
                _holoplay.TargetDisplay = (Holoplay.DisplayTarget)number;
            //Activate the display (non editor only)
#if !UNITY_EDITOR
            Display.displays[number].Activate();
#endif
        }

    }
}