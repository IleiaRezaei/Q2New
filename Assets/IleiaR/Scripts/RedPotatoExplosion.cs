using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotatoExplosion : MonoBehaviour
{
    public int explosionDamage = 100;
    public bool isExploding;

    private SpriteRenderer spriteRenderer;
    private Animator anim;

    private Rigidbody2D RigidBoy;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RigidBoy.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isExploding == true)
        {
            anim.SetBool("Explode", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            isExploding = true;

            anim.SetBool("Explosion", true);
        }
    }


}
