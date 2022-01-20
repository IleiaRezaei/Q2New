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
    private int lastattack;
    public bool go;
    public GameObject redpotat;
    public GameObject greenpotat;
    public GameObject slime;
    public bool roll;
    IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roll)
        {
            attack = 0;
            roll = false;
        }
        if(attack == 0)
        {
            
            go = false;
            if(timer >= 5)
            {
                attack = Random.Range(1,3);
                timer = 0;
            }
            else
            {
                anim.Play("idle");
                timer += Time.deltaTime;
            }
        }
        if(attack == 1)
        {
            if (go == false)
            {
                anim.Play("roar");
                GameObject obj1 = Instantiate(greenpotat, new Vector3 (transform.position.x,0,0), Quaternion.Euler(0, 0, 0));
                go = true;
            }
        }
        if(attack == 2)
        {
            if (go == false)
            {
                anim.Play("attack");
                GameObject obj1 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 0));
                obj1.GetComponent<slime>().move = true;
                GameObject obj2 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 45));
                obj2.GetComponent<slime>().move = true;
                GameObject obj3 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, -45));
                obj3.GetComponent<slime>().move = true;
                go = true;
            }
            
            
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
