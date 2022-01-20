using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour
{
    private Rigidbody2D Rigidboy;
    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        if (move)
        {
            Rigidboy = GetComponent<Rigidbody2D>();
            Rigidboy.drag = 0;
            Rigidboy.velocity = -transform.up * 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -30)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
