using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections;

public class MainScene : MonoBehaviour
{
    /*
     * States
     */
    [SerializeField] State firstState;
    State currentState;
    int index_of_current_choose = 0;

    [SerializeField] Animator anim;
    [SerializeField] TextManager textManager;

    void Start()
    {
        currentState = firstState;
        textManager.DrawAll();
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
        anim.Play("FadeIn");
        StartCoroutine(CheckAnimationCompleted("FadeIn", () =>
            {
                anim.Play("FadeOut");
                currentState = currentState.GetChoiceState()[index_of_current_choose];
                textManager.DrawAll();
            }
        ));
        index_of_current_choose = 0;
    }

    public IEnumerator CheckAnimationCompleted(string CurrentAnim, Action Oncomplete)
    {
        while (!anim.GetCurrentAnimatorStateInfo(0).IsName(CurrentAnim))
            yield return null;
        if (Oncomplete != null)
            Oncomplete();
    }

    void UpOrDownChoose()
    {
        index_of_current_choose++;
        index_of_current_choose %= currentState.GetСhoiceAmount();
        textManager.DrawAll();
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
