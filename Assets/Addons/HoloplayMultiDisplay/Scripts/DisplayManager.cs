using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Jemmec.MultiDisplay
{

    /// <summary>
    /// Manages multiple displays for Holoplay capture
    /// </summary>
    [ExecuteAlways]
    public class DisplayManager : MonoBehaviour
    {
        [SerializeField]
        private List<ExternalDisplay> _externalDisplays = new List<ExternalDisplay>();

        void OnValidate()
        {
            UpdateDisplays();
        }

        void Start()
        {
            StartCoroutine(StartRoutine());
        }

        IEnumerator StartRoutine()
        {
            //Wait two frames so it overrides Holoplay's settings
            yield return new WaitForEndOfFrame();
            yield return new WaitForEndOfFrame();
            UpdateDisplays();
        }

        void UpdateDisplays()
        {
            foreach (ExternalDisplay ed in _externalDisplays)
            {
                ed.DisplayHelper.UpdateDisplayNumber(ed.DisplayNumber);
            }
        }

    }

    [System.Serializable]
    public class ExternalDisplay
    {
        [SerializeField]
        private int _displayNumber;

        public int DisplayNumber => _displayNumber;

        [SerializeField]
        private DisplayHelper _displayHelper;

        public DisplayHelper DisplayHelper => _displayHelper;

    }

}