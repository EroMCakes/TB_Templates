using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigme_Code_Temp : MonoBehaviour
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
    public string To_Load7;



    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "WATER" ||code == "water")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load1);
            }
            else if (code == "CRYPTEX" || code == "cryptex")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load2);
            }
            else if (code == "6784")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load3);
            }
            else if (code == "VMS" || code == "vms")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load4);
            }
            else if (code == "2654")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load5);
            }
            else if (code == "750")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load6);
            }
            else if (code == "5632")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load7);
            }
            else
            {
                txt.text = "Code erroné !";
                Pass.text = null;
            }
        }
    }
}
