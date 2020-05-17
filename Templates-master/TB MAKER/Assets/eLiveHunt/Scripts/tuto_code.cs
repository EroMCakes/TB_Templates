using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tuto_code : MonoBehaviour
{
    public InputField Pass;
    public string code = null;
    public Text txt;
    public GameObject panelgg;

    public void Val()
    {
        code = Pass.text;
        if (code == "156")
        {
            txt.text = "Code valide !";
            Debug.Log("ok");
            panelgg.gameObject.SetActive(true);
        }
        else
        {
            txt.text = "Code erroné !";
            Debug.Log("pas ok");
            Pass.text = null;
        }
    }
    
        // Start is called before the first frame update
    void Start()
    {
            panelgg.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
