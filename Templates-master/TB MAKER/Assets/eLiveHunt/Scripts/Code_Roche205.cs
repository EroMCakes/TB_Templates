using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Code_Roche205 : MonoBehaviour
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
    int wordIndex = 0;
    [SerializeField] public Text Aff_alpha = null;



    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "Point Of Care" || code == "point of care")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load1);
            }
            else if (code == "8153")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load2);
            }
            else if (code == "COBAS" || code == "cobas")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load3);
            }
            else if (code == "526")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load4);
            }
            else if (code == "966859")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load5);
            }
            else if (code == "3589")
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

    public void Alpha_Function(string alpha)
    {
        wordIndex++;
        code = code + alpha + " ";
        Aff_alpha.text = code;
    }

    public void Delete_Field()
    {
        Aff_alpha.text = "";
        code = null;
        wordIndex = 0;
    }

    public void Val_Field()
    {
        if (code == "W S E N E W ")
        {
            Aff_alpha.text = "Code valide";
            UnityEngine.SceneManagement.SceneManager.LoadScene(To_Load6);
        }

        else
        {
            code = null;
            wordIndex = 0;
            Aff_alpha.text = "Code érroné";
        }
    }
}
