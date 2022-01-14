using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeneStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PauseMenu>().Closepausemenu();
        Time.timeScale = 1;
    }

}
