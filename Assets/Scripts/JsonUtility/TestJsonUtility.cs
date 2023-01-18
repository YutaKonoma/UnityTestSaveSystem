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
    [Header("�Z�[�u�f�[�^")]
    private SaveData _saveData;

    [SerializeField]
    [Header("�t�@�C���̏ꏊ")]
    private string _filePath;

    [SerializeField]
    [Header("�X�e�[�W��I������ۂ̃{�^��")]
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
    ///�X�e�[�W�N���A���ɌĂ΂��
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
    ///���[�h
    ///�V�[�����ǂݍ��܂ꂽ�Ƃ��ɌĂ�
    �@/// </summary>
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
            Debug.Log(i + 1 + "�X�e�[�W���J��");
        }
    }

    /// <summary>
    /// �Z�[�u�f�[�^�����Z�b�g�������ꍇ�ɌĂ�
    /// </summary>
    public void ResetSaveData()
    {
        _saveData.StageNumber = 0;

        var json = JsonUtility.ToJson(_saveData);
        StreamWriter streamWriter = new StreamWriter(_filePath);
        streamWriter.Write(json);
        streamWriter.Flush();
        streamWriter.Close();

        Debug.Log("���Z�b�g");
    }

    /// <summary>
    /// �t�@�C���̗L�����m�F����
    /// </summary>
    void GetFile()
    {
        if (!File.Exists(_filePath))
        {
            Debug.Log("�t�@�C�������݂��Ȃ�");
            _filePath = Application.dataPath + "/SaveData/.savedata.json";
            var json = JsonUtility.ToJson(_saveData);
            StreamWriter streamWriter = new StreamWriter(_filePath);
            streamWriter.Write(json); streamWriter.Flush();
            streamWriter.Close();
            return;
        }
    }
}
