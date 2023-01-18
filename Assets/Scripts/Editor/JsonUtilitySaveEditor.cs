using UnityEditor;
using UnityEngine;

namespace JsonUtilitSave
{
    [CustomEditor(typeof(TestJsonUtility))]
    public class JsonUtilitySaveEditor : Editor
    {
        int _stageNumber;

        public override void OnInspectorGUI()
        {
            var manager = target as TestJsonUtility;
            EditorGUILayout.LabelField("JsonUtility�Z�[�u�@�\");
            DrawDefaultInspector();

            EditorGUILayout.Space(5f);
            _stageNumber = EditorGUILayout.IntField("�ۑ��������X�e�[�W��", _stageNumber);

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("�Z�[�u"))
            {
                Debug.Log("�Z�[�u");
                manager.Save(_stageNumber);
            }
            if (GUILayout.Button("���[�h")) manager.Load();
            if (GUILayout.Button("���Z�b�g")) manager.ResetSaveData();

            EditorGUILayout.EndHorizontal();
        }
    }
}
