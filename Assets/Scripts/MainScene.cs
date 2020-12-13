using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainScene : MonoBehaviour
{
    [SerializeField] State firstState;
    State currentState;
    int index_of_current_choose = 0;

    [SerializeField] TMP_Text speechText;
    [SerializeField] TMP_Text characterText;

    [SerializeField] TMP_Text[] choiceText;

    // Start is called before the first frame update
    void Start()
    {
        currentState = firstState;
        DrawAll();
    }

    // Update is called once per frame
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
        // set background

        DrawAll();

        Debug.Log("load new scene. index: " + index_of_current_choose + "; text: " + currentState.GetText());
    }

    void UpOrDownChoose()
    {
        index_of_current_choose++;
        index_of_current_choose %= currentState.GetChoiceState().Length;
        // update UI
        Debug.Log("Current index: " + index_of_current_choose);
        DrawChoiceText();
    }

    private void DrawAll()
    {
        DrawSpeechText();
        DrawCharacter();
        DrawChoiceText();
    }

    void DrawChoiceText()
    {
        int i = 0;
        for (; i < currentState.GetChoicesText().Length; ++i)
        {
            choiceText[i].enabled = true;
            choiceText[i].text = currentState.GetChoicesText()[i];
            choiceText[i].color = Color.white;
        }
        for (int j = i; j < choiceText.Length; ++j)
        {
            choiceText[j].enabled = false;
        }
        choiceText[index_of_current_choose].color = Color.blue;
    }

    private void DrawSpeechText()
    {
        speechText.text = currentState.GetText();
    }
    private void DrawCharacter()
    {
        characterText.text = currentState.GetCharacter().GetNickname();
    }
}
