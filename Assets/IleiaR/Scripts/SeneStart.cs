using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeneStart : MonoBehaviour
{
    public bool pausemenu;
    public GameObject pausemenumenu;

    // Start is called before the first frame update
    void Start()
    {
       
        
            if (pausemenu == false)
            {
                openPausemenu();
                pausemenu = true;
            }
            else if (pausemenu == true)
            {
                Closepausemenu();
                pausemenu = false;
            }

        void openPausemenu()
        {
            Time.timeScale = 0;
            pausemenumenu.SetActive(true);
        }

        void Closepausemenu()
        {
            pausemenumenu.SetActive(false);
            Time.timeScale = 1;
        }

    }

}
