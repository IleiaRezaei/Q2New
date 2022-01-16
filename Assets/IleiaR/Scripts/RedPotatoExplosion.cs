using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotatoExplosion : MonoBehaviour
{
    public int explosionDamage = 100;
    public bool isExploding;

    private SpriteRenderer spriteRenderer;
    private Animator anim_RedPot;

    private Rigidbody2D RigidBoy;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RigidBoy.GetComponent<Rigidbody2D>();
        anim_RedPot = GetComponent<Animator>();

        isExploding = false;
        //anim_RedPot.SetBool("RedExplode", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isExploding == true)
        {
            //anim_RedPot.Play("Explosion");
            //anim_RedPot.SetBool("Explode", true);
        }

        //Debug.Log(isExploding);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("--------------------------hit" + collision.gameObject.tag);
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Hi---------");

            isExploding = true;

            //anim_RedPot.SetBool("Explode", true);
            anim_RedPot.Play("Explosion");
        }
    }


}
