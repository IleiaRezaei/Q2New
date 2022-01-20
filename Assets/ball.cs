using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{
    public int damage;
    public Vector2 Knockback;
    private Rigidbody2D Rigidboy;
    public bool held;

    public GameObject me;

    private IEnumerator coroutine;

    private void Start()
    {
        Rigidboy = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Knockback = GetComponent<Rigidbody2D>().velocity *500;
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
                Rigidboy.angularVelocity = 0;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                held = true;
                gameObject.layer = 9;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                GetComponent<Rigidbody2D>().freezeRotation = false;
                Rigidboy.drag = 5;
                Rigidboy.angularDrag = 0.5F;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().heldobj = this.gameObject;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding = true;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().ball = true;
            }
        }
        else
        {
            tag = "Untagged";
        }
        if(collision.gameObject.tag == "RedPotato" || collision.gameObject.tag == "RedPotatoDamage" || collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(WaitForSeconds());
            Destroy(me);
        }

        IEnumerator WaitForSeconds()
        {
            yield return new WaitForSeconds((int)1.1);
        }
    }
}
