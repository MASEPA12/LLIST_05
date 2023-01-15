using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{
    //here's the array with no defined lenght
    public int[] ARRAY;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //we access the number 1,3 and 5 of the array through;
            Debug.Log($"First element = {ARRAY[1]}");
            Debug.Log($"Third element = {ARRAY[2]}");
            Debug.Log($"Fifth element = {ARRAY[3]}");
        }
    }
}
