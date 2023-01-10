using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData", order = 0)]
public class CharacterData : ScriptableObject
{

    public float speed;
    public ScriptableObject headPart;
    public ScriptableObject bodyPart;
}