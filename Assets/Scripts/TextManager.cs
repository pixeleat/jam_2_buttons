﻿using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] TMP_Text characterText;
    [SerializeField] TMP_Text speechText;
    [SerializeField] TMP_Text[] choiceText;

    [SerializeField] MainScene scene;

    public void DrawAll()
    {
        DrawChoiceText();
        DrawSpeechText();
        DrawCharacter();
    }

    private void DrawChoiceText()
    {
        for (int i = 0; i < scene.GetCurrentState().GetСhoiceAmount(); ++i)
        {
            Color color = Constants.DEFAULT_TEXT_COLOR;
            if (scene.GetIndexOfCurrentChoose() == i)
            {
                color = Constants.SELECTED_TEXT_COLOR;
            }
            SetPropertiesForText(i, true, scene.GetCurrentState().GetChoicesText()[i], color);
        }
        for (int j = scene.GetCurrentState().GetСhoiceAmount(); j < Constants.MAX_CHOISE_AMOUNT; ++j)
        {
            SetPropertiesForText(j, false, "", Constants.DEFAULT_TEXT_COLOR);
        }
    }

    private void DrawSpeechText()
    {
        SetSpeechText(scene.GetCurrentState().GetText());
    }

    private void DrawCharacter()
    {
        SetCharacterText(scene.GetCurrentState().GetCharacter().GetNickname());
    }

    public void SetSpeechText(string text)
    {
        speechText.text = text;
    }

    public void SetCharacterText(string text)
    {
        characterText.text = text;
    }

    public void SetPropertiesForText(int index, bool vis, string text, Color color)
    {
        choiceText[index].enabled = vis;
        choiceText[index].text = text;
        choiceText[index].color = color;
    }

}
