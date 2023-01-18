using UnityEditor;
using UnityEngine;

namespace JsonUtilitSave
{
    [CustomEditor(typeof(TestJsonUtility))]
    public class JsonUtilitySaveEditor : Editor
    {
        int _stageNunber;

        public override void OnInspectorGUI()
        {
            var maneger = target as TestJsonUtility;
            EditorGUILayout.LabelField("�Z�[�u�@�\");
            DrawDefaultInspector();

            EditorGUILayout.Space(5f);
            _stageNunber = EditorGUILayout.IntField("�ۑ��������X�e�[�W��", _stageNunber);

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("�Z�[�u"))
            {
                Debug.Log("�Z�[�u");
                maneger.Save(_stageNunber);
            }
            if (GUILayout.Button("���[�h")) maneger.Load();
            if (GUILayout.Button("���Z�b�g")) maneger.ResetSaveData();

            EditorGUILayout.EndHorizontal();
        }
    }
}
