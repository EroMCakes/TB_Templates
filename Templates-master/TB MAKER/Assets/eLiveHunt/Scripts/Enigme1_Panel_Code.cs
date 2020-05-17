using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enigme1_Panel_Code : MonoBehaviour
{
    public GameObject Panel_Code;
    public GameObject Boutton;

    public void close_panel()
    {
        Panel_Code.gameObject.SetActive(false);
        Boutton.gameObject.SetActive(true);
    }

    public void open_panel()
    {
        Panel_Code.gameObject.SetActive(true);
        Boutton.gameObject.SetActive(false);
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
