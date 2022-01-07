using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHP : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP = 100;

    public GameObject player;
    GameObject bean;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP == 0)
        {
            Destroy(player);
        }

        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "regularBean" && currentHP < 100)
        {
            currentHP += 20;
            Destroy(collision.gameObject);
        }
    }
}
