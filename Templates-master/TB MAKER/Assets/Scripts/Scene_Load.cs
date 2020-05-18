using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Load : MonoBehaviour {

    public void Load_Scene(string Scene_Name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Scene_Name);
    }
}
