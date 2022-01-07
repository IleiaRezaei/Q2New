using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyEnmy : MonoBehaviour
{
    public int hp = 100;
    Vector3 pos;
    private Rigidbody2D rigifdbe;
    private bool knocked;
    // Start is called before the first frame update
    void Start()
    {
        rigifdbe = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            int dam = collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().damage;
            Vector2 knock = collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().knockback;
            hp -= dam;
            rigifdbe.AddForce(knock);
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

