using UnityEngine;
using UnityEditor;

namespace Klak.Timeline
{
    [CustomEditor(typeof(MidiSignalReceiver))]
    sealed class MidiSignalReceiverEditor : Editor
    {
        SerializedProperty _noteFilter;
        SerializedProperty _noteOnEvent;

        static readonly GUIContent _labelNoteOctave = new GUIContent("Note/Octave");

        void OnEnable()
        {
            _noteFilter = serializedObject.FindProperty("noteFilter");
            _noteOnEvent = serializedObject.FindProperty("noteOnEvent");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_noteFilter, _labelNoteOctave);
            EditorGUILayout.PropertyField(_noteOnEvent);

            serializedObject.ApplyModifiedProperties();
        }
    }
}