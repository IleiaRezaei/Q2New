using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startboss : MonoBehaviour
{
    public GameObject wall1;
    public GameObject wall2;
    public GameObject boss;
    // Start is called before the first frame update
    void Start()
    {
        wall1.active = false;
        wall2.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wall1.active = true;
            wall2.active = true;
            boss.GetComponent<boss>().on = true;
            gameObject.active = false;

        }
    }
}
