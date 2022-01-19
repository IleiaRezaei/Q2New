using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    //public bool pausemenu;
    //public GameObject pause;
    //public GameObject pausemenumenu;
    

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Start");
    }

}
