using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Keypad_Load : MonoBehaviour {

    public void ChangeScene(string a)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(a); 

    }

    public void CloseAppButton()
    {
        Application.Quit();
    }
}
