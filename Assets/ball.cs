using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
    public float damage;
    public Vector2 Knockback;
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
