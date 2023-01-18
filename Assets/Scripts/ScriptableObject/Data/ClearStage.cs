using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName  = "ScriptableObjects/ClearStageNuber")]
public class ClearStage : ScriptableObject
{
    [SerializeField]
    public int  StageNumber;
}
