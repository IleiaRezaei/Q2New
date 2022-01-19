using System.Collections;
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
    IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        attack = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {

        if (dead == false)
        {

            anim.SetInteger("attack", attack);
            if (attack == 0)
            {
                if (go == false)
                {
                    StartCoroutine(waitForSeconds());
                    attack = Random.Range(1, 2);
                }
                
            }
            if (attack == 1)
            {
                if (attacking)
                {
                    attacking = false;
                }
            }
            if (attack == 2)
            {
                if (attacking)
                {
                    attacking = false;
                }
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
    IEnumerator waitForSeconds()
    {
        print("yo0");
        go = true;
        yield return new WaitForSeconds(5);
        print("yo1");

        
    }
}
