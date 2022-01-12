using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool pausemenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if(pausemenu == false)
            {
                openPausemenu();
                pausemenu = true;
            }
            else
            {
                Closepausemenu();
                pausemenu = false;
            }

        }
    }
    void openPausemenu()
    {
        Time.timeScale = 0;
    }
    
    void Closepausemenu()
    {
        Time.timeScale = 1;
    }
} 
