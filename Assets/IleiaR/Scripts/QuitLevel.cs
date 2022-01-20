using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{

    //public bool pausemenu;
    //public GameObject pause;
    public GameObject pausemenumenu;
    public void Closepausemenu()
    {
        pausemenumenu.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;     
        
        
    }

}
