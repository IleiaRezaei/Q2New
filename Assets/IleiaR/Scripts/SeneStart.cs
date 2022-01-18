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
        PauseMenu PauseMenuScript = pausemenumenu.GetComponent<PauseMenu>();
        PauseMenuScript.openPausemenu();
        PauseMenuScript.Closepausemenu();
    }

}
