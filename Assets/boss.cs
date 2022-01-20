﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss : MonoBehaviour
{
    public int hp;
    public int attack = 0;
    public bool dead;
    public bool attacking;
    private Animator anim;
    public float timer;
    public bool go;
    public GameObject redpotat;
    public GameObject greenpotat;
    public GameObject slime;
    IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attack == 0)
        {
            anim.Play("idle");
            go = false;
        }
        if(attack == 1)
        {
            anim.Play("roar");
        }
        if(attack == 2)
        {
            if (go == false)
            {
                GameObject obj1 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 0));
                obj1.GetComponent<slime>().move = true;
                GameObject obj2 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 45));
                obj2.GetComponent<slime>().move = true;
                GameObject obj3 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, -45));
                obj3.GetComponent<slime>().move = true;
                go = true;
            }
            anim.Play("attack");
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ThrownObj")
        {
            int dam = collision.gameObject.GetComponent<ball>().damage;
            hp -= dam / 2;

            if (hp <= 0)
            {
                dead = true;
            }
        }
    }
}
