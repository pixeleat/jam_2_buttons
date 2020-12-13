using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    [SerializeField] State firstState;
    State currentState;
    // Start is called before the first frame update
    void Start()
    {
        currentState = firstState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    State getCurrentState()
    {
        return currentState;
    }
}
