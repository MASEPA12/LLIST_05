using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    //Variable declaration
    public float Value_1;
    public float Value_2;
    public float Value_3;

    
    void Update()
    {
        //if the key space is pressed, it calls the function and returns the result (D)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"The arithmetic Mean of {Value_1}, {Value_2}, {Value_3} is {arithmeticMean(Value_1, Value_2, Value_3)}");
        }
    }

    private float arithmeticMean (float A, float B, float C)
    {
        float D;
        D = (A + B + C) / 3;
        return D;
    }

}
