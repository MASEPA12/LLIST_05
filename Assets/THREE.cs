using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREE : MonoBehaviour
{
    private int COUNTER;

    void Update()
    {
        //If the player press A, call counter 
        if (Input.GetKeyDown(KeyCode.A))
        {
            counter();
        }
    }

    private void counter()
    {
        //sum one to the counter and check if it's equal to 10,
        //if it is the case, Game over
        COUNTER++;

        if (COUNTER == 10)
        {
            Debug.Log("GAME OVER");
        }
    }
}
