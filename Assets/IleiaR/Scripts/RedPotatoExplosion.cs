using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotatoExplosion : MonoBehaviour
{
    public int explosionDamage = 100;
    public bool isExploding;

    private SpriteRenderer spriteRenderer;

    private Animator animRedPot;

    private Rigidbody2D RigidBoy;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RigidBoy.GetComponent<Rigidbody2D>();

        animRedPot = GetComponent<Animator>();

        isExploding = false;
        //anim_RedPot.SetBool("RedExplode", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isExploding == true)
        {
            //anim_RedPot.Play("Explosion");
            //animRedPot.SetBool("Explode", true);
            animRedPot.SetBool("ex", true);
        }

        //Debug.Log(isExploding);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("--------------------------hit" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hi---------");

            isExploding = true;
            animRedPot.SetBool("Explode", true);
            //anim_RedPot.SetBool("Explode", true);
            //animRedPot.Play("Explosion");
            //animRedPot.SetBool("isAttacking", false);

        }
    }

}
