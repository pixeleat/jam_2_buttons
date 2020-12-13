using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Z is pressed");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X is pressed");
        }
    }
}
