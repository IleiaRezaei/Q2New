using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMoveTest : MonoBehaviour
{
    public GameObject player;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Vector3 dir = (player.transform.position - transform.position).normalized;
            transform.position += new Vector3(dir.x, dir.y, 0) * 0.012F;
            if (dir.x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (dir.x < 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}
