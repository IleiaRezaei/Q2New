using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
    public int damage;
    public Vector2 Knockback;

    private void Update()
    {
        Knockback = GetComponent<Rigidbody2D>().velocity;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            if (collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding != true)
            {
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().heldobj = this.gameObject;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding = true;
            }
        }
    }
}
