using Script;
using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "AI/State")]
public class State : ScriptableObject
{
    public float DetectionRange;
    public float Speed;
    public AIStateType StateType;
}
