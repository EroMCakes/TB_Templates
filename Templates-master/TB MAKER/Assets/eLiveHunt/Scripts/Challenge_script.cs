using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Challenge_script : MonoBehaviour
{
    public string Chall;
    public string ToLoad;
    public string sheraz_lev;
    public string temp_lev;
    public string pir_lev;
    public GameObject script_holder;

    // Start is called before the first frame update
    void Start()
    {
        Chall = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Dontdest()
    {
        DontDestroyOnLoad(script_holder);
    }

    public void Load_Sheraz()
    {
        Chall = "sheraz";
        Dontdest();
        UnityEngine.SceneManagement.SceneManager.LoadScene(ToLoad);
    }

    public void Load_Temp()
    {
        Chall = "temp";
        Dontdest();
        UnityEngine.SceneManagement.SceneManager.LoadScene(ToLoad);
    }

    public void Load_pir()
    {
        Chall = "pir";
        Dontdest();
        UnityEngine.SceneManagement.SceneManager.LoadScene(ToLoad);
    }

    public void Lev_Load()
    {
        if (Chall == "sheraz")
        {
            Object.Destroy(script_holder);
            UnityEngine.SceneManagement.SceneManager.LoadScene(sheraz_lev);
        }

        else if (Chall == "temp")
        {
            Object.Destroy(script_holder);
            UnityEngine.SceneManagement.SceneManager.LoadScene(temp_lev);
        }

        else if (Chall == "pir")
        {
            Object.Destroy(script_holder);
            UnityEngine.SceneManagement.SceneManager.LoadScene(pir_lev);
        }
    }
}
