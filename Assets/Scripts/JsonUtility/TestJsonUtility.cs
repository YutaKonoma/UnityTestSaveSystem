using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int StageNumber = 0;
}

public class TestJsonUtility : MonoBehaviour
{
    [SerializeField]
    [Header("セーブデータ")]
    private SaveData _saveData;

    [SerializeField]
    [Header("ファイルの場所")]
    private string _filePath;

    [SerializeField]
    [Header("ステージを選択する際のボタン")]
    private GameObject[] _stageButton;

    void Start()
    {
        _filePath = Application.dataPath + "/SaveData/.savedata.json";

        GetFile();

        foreach (var chr in _stageButton)
        {
            chr.SetActive(false);
        }

        Load();
    }

    ///<summary>
    ///ステージクリア時に呼ばれる
    ///<summary>
    public void Save(int nowStageNumber)
    {
        GetFile();
        _saveData.StageNumber = nowStageNumber;
        Debug.Log(_saveData.StageNumber);
        var json = JsonUtility.ToJson(_saveData);
        StreamWriter streamWriter = new StreamWriter(_filePath);
        streamWriter.Write(json);
        streamWriter.Flush();
        streamWriter.Close();
    }

    /// <summary>
    ///ロード
    ///シーンが読み込まれたときに呼ぶ
    　/// </summary>
    public void Load()
    {
        GetFile();
        var streamReader = new StreamReader(_filePath);
        string _data = streamReader.ReadToEnd();
        streamReader.Close();

        _saveData = JsonUtility.FromJson<SaveData>(_data);

        for (int i = 0; i <= _saveData.StageNumber; i++)
        {
            _stageButton[i].SetActive(true);
            Debug.Log(i + 1 + "ステージを開放");
        }
    }

    /// <summary>
    /// セーブデータをリセットしたい場合に呼ぶ
    /// </summary>
    public void ResetSaveData()
    {
        _saveData.StageNumber = 0;

        var json = JsonUtility.ToJson(_saveData);
        StreamWriter streamWriter = new StreamWriter(_filePath);
        streamWriter.Write(json);
        streamWriter.Flush();
        streamWriter.Close();

        Debug.Log("リセット");
    }

    /// <summary>
    /// ファイルの有無を確認する
    /// </summary>
    void GetFile()
    {
        if (!File.Exists(_filePath))
        {
            Debug.Log("ファイルが存在しない");
            _filePath = Application.dataPath + "/SaveData/.savedata.json";
            var json = JsonUtility.ToJson(_saveData);
            StreamWriter streamWriter = new StreamWriter(_filePath);
            streamWriter.Write(json); streamWriter.Flush();
            streamWriter.Close();
            return;
        }
    }
}
