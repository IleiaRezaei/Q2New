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
        Vector3 dir = (player.transform.position - transform.position);
        print(Mathf.Abs(dir.x));
        if (move && Mathf.Abs(dir.x) <= 5)
        {
            transform.position += new Vector3(dir.normalized.x, dir.normalized.y, 0) * 0.012F;
            if (dir.normalized.x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (dir.normalized.x < 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}
