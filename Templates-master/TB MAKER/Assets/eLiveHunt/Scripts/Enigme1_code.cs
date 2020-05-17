using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigme1_code : MonoBehaviour
{

    public InputField Pass;
    public string code = null;
    public Text txt;
    public string To_Load1;
    public string To_Load2;
    public string To_Load3;
    public string To_Load4;
    public string To_Load5;
    public string To_Load6;



    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "1735")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load1);
            }
            else if(code == "5384")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load3);
            }
            else if (code == "586")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load4);
            }
            else if (code == "369")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load5);
            }
            else if (code == "319")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load6);
            }
            else if (code == "132")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load1);
            }
            else if (code == "PLC" || code == "plc")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load2);
            }
            else
            {
                txt.text = "Code erroné !";
                Pass.text = null;
            }
        }
    }
}
