﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public bool playerDeath;
    public GameObject playerDeathScene;
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
            if(Players == 0)
            {
                openplayerDeath();
                playerDeath = true;

            }
            
        }

    }
    public void openplayerDeath()
    {
        playerDeathScene.SetActive(true);
    }
}
