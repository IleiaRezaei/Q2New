using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : StateMachineBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
    
}
