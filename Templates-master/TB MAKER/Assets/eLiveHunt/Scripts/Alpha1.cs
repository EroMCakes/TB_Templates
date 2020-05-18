using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha1 : MonoBehaviour
{

    string code = null;
    int wordIndex = 0;
    [SerializeField] public Text Aff_alpha = null;

    [SerializeField] string scene;
   

    public void Alpha_Function(string alpha)
    {
        wordIndex++;
        code = code + alpha;
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
        if (code == "NGI")
        {
            Aff_alpha.text = "Code valide";
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }

        else
        {
            code = null;
            wordIndex = 0;
            Aff_alpha.text = "Code érroné";
        }
    }

}



