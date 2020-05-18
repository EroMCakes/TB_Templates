using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Num_Portrait : MonoBehaviour
{

    string code = null;
    int wordIndex = 1;
    [SerializeField] public Text Aff_Num = null;

    [SerializeField] string scene1;




    public void number_function(int number)
    {
        if (wordIndex < 4)
        {
            wordIndex++;
            code = code + number;
            Aff_Num.text = code;
        }
    }

    public void Delete_Field()
    {
        Aff_Num.text = "";
        code = null;
        wordIndex = 1;
    }

    public void Val_Field()
    {
        if (code == "817")
        {
            Aff_Num.text = "Code valide";
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene1);
        }

        else
        {
            code = null;
            wordIndex = 1;
            Aff_Num.text = "Code érroné";
        }
    }

}
