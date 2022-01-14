using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
    public int damage;
    public Vector2 Knockback;
    private Rigidbody2D Rigidboy;
    public bool held;
    private void Start()
    {
        Rigidboy = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Knockback = GetComponent<Rigidbody2D>().velocity;
        if (Rigidboy.velocity == new Vector2() && held == false)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().freezeRotation = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.layer = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            if (collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding != true)
            {
                held = true;
                gameObject.layer = 9;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                GetComponent<Rigidbody2D>().freezeRotation = false;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().heldobj = this.gameObject;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding = true;
            }
        }
        else
        {

            tag = "Untagged";
        }
    }
}
