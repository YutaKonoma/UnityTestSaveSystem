using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(ScriptableObjctSaveTest))]
public class ScriptableObjectSaveEditor : Editor
{
    int _nowStageNumber;
    public override void OnInspectorGUI()
    {
        var manager = target as ScriptableObjctSaveTest;

        EditorGUILayout.LabelField("ScriptableObject�Z�[�u�@�\");
        DrawDefaultInspector();

        EditorGUILayout.Space(5);
        _nowStageNumber = EditorGUILayout.IntField("�ۑ��������X�e�[�W��", _nowStageNumber);

        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("���[�h")) manager.Load();
        if (GUILayout.Button("�Z�[�u")) manager.Save(_nowStageNumber);
        if (GUILayout.Button("���Z�b�g")) manager.ResetSaveData();

        EditorGUILayout.EndHorizontal();
    }
}
