using UnityEngine;

[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [SerializeField] Character character;
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    // sound
    // delay sound
    // background

    
    public string GetStateStory()
    {
        return storyText;
    }
    public State[] GetNextStates()
    {
        return nextStates;
    }

    public string GetText()
    {
        return storyText;
    }
}