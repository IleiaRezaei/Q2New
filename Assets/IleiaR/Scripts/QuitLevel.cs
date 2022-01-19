using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    //public bool pausemenu;
    //public GameObject pause;
    //public GameObject pausemenumenu;
    //public void LoadNextScene()
    void Update()
    {
        //if (pausemenu == true)
        //{
        //Closepausemenu();
        //pausemenu = false;
        //}
        //void Closepausemenu()
        //{
        //pausemenumenu.SetActive(false);
        //Time.timeScale = 1;
        //}

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene("Start");
            //GetComponent<PauseMenu>().Closepausemenu();
        }
    }
}
