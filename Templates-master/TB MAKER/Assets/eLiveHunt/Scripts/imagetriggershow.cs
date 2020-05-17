using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class imagetriggershow : MonoBehaviour
{
    
    public GameObject Imagetriggered1;
    public GameObject Imagetriggered2;

    // Start is called before the first frame update
    void Start()
    {
        Imagetriggered1.gameObject.SetActive(false);
        Imagetriggered2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void imagekeep()
    {
        Imagetriggered1.gameObject.SetActive(true);
        Imagetriggered2.gameObject.SetActive(true);
    }
    
}
