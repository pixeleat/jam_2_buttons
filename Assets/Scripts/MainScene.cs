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

    // Start is called before the first frame update
    void Start()
    {
        currentState = firstState;
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

    public void LoadNextState()
    {
        currentState = currentState.GetNextStates()[index_of_current_choose];
        index_of_current_choose = 0;
        // set background
        // set text
        // set name of character
        speechText.text = currentState.GetText();
        characterText.text = currentState.GetCharacter().GetNickname();
        Debug.Log("load new scene. index: " + index_of_current_choose + "; text: " + currentState.GetText());
    }

    public void UpOrDownChoose()
    {
        index_of_current_choose++;
        index_of_current_choose %= currentState.GetNextStates().Length;
        // update UI
        Debug.Log("Current index: " + index_of_current_choose);
    }
}
