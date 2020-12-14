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

    void Start()
    {
        currentState = firstState;
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
    }

    void UpOrDownChoose()
    {
        index_of_current_choose++;
        index_of_current_choose %= currentState.GetСhoiceAmount();
    }

    public int GetIndexOfCurrentChoose()
    {
        return index_of_current_choose;
    }

    public State GetCurrentState()
    {
        return currentState;
    }
}
