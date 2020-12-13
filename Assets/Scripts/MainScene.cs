using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainScene : MonoBehaviour
{
    /*
     * States
     */
    [SerializeField] State firstState;
    State currentState;
    int index_of_current_choose = 0;

    /*
     * Text Objects
     */
    [SerializeField] TMP_Text speechText;
    [SerializeField] TMP_Text characterText;
    [SerializeField] TMP_Text[] choiceText;

    /*
     * Drawer
     */
    Drawer drawer;

    void Start()
    {
        drawer = new Drawer(this);
        currentState = firstState;
        drawer.DrawAll();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            UpOrDownChoose();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            LoadNextState();
        }
    }

    void LoadNextState()
    {
        currentState = currentState.GetChoiceState()[index_of_current_choose];
        index_of_current_choose = 0;
        drawer.DrawAll();
    }

    void UpOrDownChoose()
    {
        index_of_current_choose++;
        index_of_current_choose %= currentState.GetСhoiceAmount();
        drawer.DrawAll();
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

    public int GetIndexOfCurrentChoose()
    {
        return index_of_current_choose;
    }

    public State GetCurrentState()
    {
        return currentState;
    }

    public int GetСountOfTextsToChoose()
    {
        return choiceText.Length;
    }
}
