using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjctSaveTest : MonoBehaviour
{
    [SerializeField]
    ClearStage _saveData;

    [SerializeField]
    int _stageNumber;

    [SerializeField]
    [Header("�X�e�[�W��I������ۂ̃{�^��")]
    private GameObject[] _stageButton;

    private void Start()
    {
        foreach (var chr in _stageButton)
        {
            chr.SetActive(false);
        }

        Load();
    }

    public void Save(int nowStageNumber)
    {
        _saveData.StageNumber = nowStageNumber;
    }

    public void Load()
    {
        _stageNumber = _saveData.StageNumber;
        Debug.Log(_stageNumber);
        for (int i = 0; i <= _saveData.StageNumber; i++)
        {
            _stageButton[i].SetActive(true);
            Debug.Log(i + 1 + "�X�e�[�W���J��");
        }
    }

    public void ResetSaveData()
    {
        _saveData.StageNumber = 0;
        Debug.Log("���Z�b�g");
    }
}
