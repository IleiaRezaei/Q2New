using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    public GameObject pause;
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Start");
        GetComponent<PauseMenu>().Closepausemenu();
    }
}
