using UnityEngine;

/*
 * Updates objects in the scene
 */
class Drawer
{
    readonly MainScene scene;

    public Drawer(MainScene s)
    {
        scene = s;
    }

    public void DrawAll()
    {
        DrawSpeechText();
        DrawCharacter();
        DrawChoiceText();
    }

    private void DrawChoiceText()
    {
        for (int i = 0; i < scene.GetCurrentState().GetСhoiceAmount(); ++i)
        {
            Color color = Color.white;
            if (scene.GetIndexOfCurrentChoose() == i)
            {
                color = Color.blue;
            }
            scene.SetPropertiesForText(i, true, scene.GetCurrentState().GetChoicesText()[i], color);
        }
        for (int j = scene.GetCurrentState().GetСhoiceAmount(); j < scene.GetСountOfTextsToChoose(); ++j)
        {
            Debug.Log("GetСountOfTextsToChoose: " + scene.GetСountOfTextsToChoose());
            scene.SetPropertiesForText(j, false, "", Color.white);
        }
    }

    private void DrawSpeechText()
    {
        scene.SetSpeechText(scene.GetCurrentState().GetText());
    }

    private void DrawCharacter()
    {
        scene.SetCharacterText(scene.GetCurrentState().GetCharacter().GetNickname());
    }
}