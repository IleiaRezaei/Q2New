using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : StateMachineBehaviour
{
    void Start()
    {
        Debug.Log("cum");
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
    
}
