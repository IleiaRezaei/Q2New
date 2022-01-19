using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstRockWall : MonoBehaviour
{
    public GameObject thisObj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerAttack")
        {
            Destroy(thisObj);

        }
    }
}
