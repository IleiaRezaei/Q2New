using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    public int health = 100;
    public int maxhealth = 100;

    private Rigidbody2D rb;

    private SpriteRenderer sprt;

    private CapsuleCollider2D hitbox;

    private Collider2D lhit;

    public bool dead = false;


    // Start is called before the first frame update
    void Start()    
    {
        rb = GetComponent<Rigidbody2D>();
        sprt = GetComponent<SpriteRenderer>();
        hitbox = transform.GetChild(0).GetComponent<CapsuleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.gameObject.tag == "PlayerAttack")
        {
            int dam = collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().damage;
            Vector2 knock = collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().knockback * Time.deltaTime;
            health -= dam / 2;
            rb.AddForce(knock);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "ThrownObj")
        {
            if (lhit != collision)
            {
                int dam = collision.gameObject.GetComponent<ball>().damage;
                Vector2 knock = collision.gameObject.GetComponent<ball>().Knockback * Time.deltaTime;
                rb.AddForce(knock);
                health -= dam/2;

                if (health <= 0)
                {
                    GetComponent<Animator>().Play("die");
                }
            }
        }
        if (collision.gameObject.tag == "RedPotatoDamage")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//