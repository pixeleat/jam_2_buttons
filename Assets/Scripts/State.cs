using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [SerializeField] Character character;
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] string[] choiceText;
    [SerializeField] State[] choiceState;
    // sound
    // delay sound
    // background


    public string GetStateStory()
    {
        return storyText;
    }
    public string[] GetChoicesText()
    {
        return choiceText;
    }
    public State[] GetChoiceState()
    {
        return choiceState;
    }

    public string GetText()
    {
        return storyText;
    }

    public Character GetCharacter()
    {
        return character;
    }
}