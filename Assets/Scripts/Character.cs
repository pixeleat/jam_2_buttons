using UnityEngine;

[CreateAssetMenu(menuName = "Character")]
public class Character : ScriptableObject
{
    [SerializeField] string nickname;

    public string GetNickname()
    {
        return nickname;
    }
}
