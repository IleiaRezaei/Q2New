using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpause : MonoBehaviour
{
    public bool pausemenu;
    public GameObject pausemenumenu;

    // Start is called before the first frame update
    void Start()
    {
        if (pausemenu == true)
        {
            Closepausemenu();
            pausemenu = false;
        }

        void Closepausemenu()
        {
            pausemenumenu.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
