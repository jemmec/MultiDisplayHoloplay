using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Jemmec.MultiDisplay
{
    [CustomEditor(typeof(DisplayHelper), true)]
    public class DisplayHelperEditor : Editor
    {
        // Start is called before the first frame update
        public override void OnInspectorGUI()
        {
            DisplayHelper script = (DisplayHelper)target;
            EditorGUILayout.PropertyField(serializedObject.FindProperty("_type"), new GUIContent("Type"), true);
            switch (script.Type)
            {
                case DisplayHelperType.HoloplayCapture:
                    {
                        EditorGUILayout.PropertyField(serializedObject.FindProperty("_holoplay"), new GUIContent("Holoplay"), true);
                        break;
                    }
                case DisplayHelperType.UnityCamera:
                    {
                        EditorGUILayout.PropertyField(serializedObject.FindProperty("_camera"), new GUIContent("Camera"), true);
                        break;
                    }
                case DisplayHelperType.UserInterface:
                    {
                        EditorGUILayout.PropertyField(serializedObject.FindProperty("_camera"), new GUIContent("Camera"), true);
                        EditorGUILayout.PropertyField(serializedObject.FindProperty("_canvas"), new GUIContent("Canvas"), true);
                        break;
                    }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
