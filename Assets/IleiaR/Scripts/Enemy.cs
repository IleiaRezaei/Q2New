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


    // Start is called before the first frame update
    void Start()    
    {
        rb = GetComponent<Rigidbody2D>();
        sprt = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {


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