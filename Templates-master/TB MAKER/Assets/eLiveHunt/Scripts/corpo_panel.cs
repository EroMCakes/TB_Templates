using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corpo_panel : MonoBehaviour
{
    public GameObject Panel_Code;
    public InputField Pass;
    public string code = null;
    public Text txt;
    public string scene;

    public void Enter_Push()
    {
        code = Pass.text;
        if (Pass.text != null)
        {
            if (code == "RO205CH202E0")
            {
                txt.text = "Code valide !";
                UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
            }
            else
            {
                txt.text = "Code erroné !";
                Pass.text = null;
            }
        }
    }

    public void close_panel()
    {
        Panel_Code.gameObject.SetActive(false);
    }

    public void open_panel()
    {
        Panel_Code.gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Panel_Code.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}