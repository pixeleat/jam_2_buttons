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
        // load current sceen
        // 
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Z is pressed");
            // down/up choose
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X is pressed");
            // load next sceen
        }
    }
}
