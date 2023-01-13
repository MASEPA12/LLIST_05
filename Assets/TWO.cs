using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    public string username;
    public string password;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Login(username, password) == false)
            {
                Debug.Log($"FALSE; The username or the password is not correct");
            }
            else
            {
                Debug.Log($"TRUE; The username or the password is correct");
            }
        }
        
    }

    private bool Login(string Username, string Password)
    {
        //if the text in the variables is equal to user = admin and
        //pasword = abccba it will be true
        if (Username == "admin" && Password == "abccba")
        {
            return true;
        }
            return false;
    }
}
