using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public bool playerDeathMenu;
    public GameObject PlayerDeathScene;
    public GameObject[] Player;
    public int Players;
    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");
        
    }


    void Update()
    {
        Players = 0;
        foreach (GameObject p in Player)
        {
            if(p != null)
            {
                Players++;
            }
            
            
        }
        if (Players <= 0)
        {
            openplayerDeath();
            playerDeathMenu = true;

        }
    }
    public void openplayerDeath()
    {
        Time.timeScale = 0;
        PlayerDeathScene.SetActive(true);
    }
}

