using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Team_panel_script : MonoBehaviour
{
    public GameObject[] Panels;

    public void select3()
    {
        Panels[0].gameObject.SetActive(false);
        Panels[1].gameObject.SetActive(true);
    }

    public void select4()
    {
        Panels[0].gameObject.SetActive(false);
        Panels[2].gameObject.SetActive(true);
    }

    public void select5()
    {
        Panels[0].gameObject.SetActive(false);
        Panels[3].gameObject.SetActive(true);
    }

    public void select6()
    {
        Panels[0].gameObject.SetActive(false);
        Panels[4].gameObject.SetActive(true);
    }

    public void close1()
    {
        Panels[1].gameObject.SetActive(false);
        Panels[0].gameObject.SetActive(true);
    }

    public void close2()
    {
        Panels[2].gameObject.SetActive(false);
        Panels[0].gameObject.SetActive(true);
    }

    public void close3()
    {
        Panels[3].gameObject.SetActive(false);
        Panels[0].gameObject.SetActive(true);
    }

    public void close4()
    {
        Panels[4].gameObject.SetActive(false);
        Panels[0].gameObject.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        int i = 1;
        while(i < 5)
        {
            Panels[i].gameObject.SetActive(false);
            i++;
        }
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
