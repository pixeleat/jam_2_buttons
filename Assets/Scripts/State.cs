using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [SerializeField] Character character;
    [TextArea(14, 10)] [SerializeField] string storyText;

    // size of choiceText and choiseState must be equal!
    [SerializeField] string[] choiceText;
    [SerializeField] State[] choiceState;
    // TODO:
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

    public int GetСhoiceAmount()
    {
        return choiceState.Length;
    }
}