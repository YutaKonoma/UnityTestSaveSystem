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

        EditorGUILayout.LabelField("ScriptableObjectセーブ機能");
        DrawDefaultInspector();

        EditorGUILayout.Space(5);
        _nowStageNumber = EditorGUILayout.IntField("保存したいステージ数", _nowStageNumber);

        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("ロード")) manager.Load();
        if (GUILayout.Button("セーブ")) manager.Save(_nowStageNumber);
        if (GUILayout.Button("リセット")) manager.ResetSaveData();

        EditorGUILayout.EndHorizontal();
    }
}
