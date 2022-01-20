using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLeafScript : MonoBehaviour
{
    public GameObject Wall;
    public GameObject Wall2;
    public GameObject Wall3;

    public GameObject[] enemy1;
    public GameObject[] enemy2;
    public GameObject[] enemy3;

    private SpriteRenderer spriteR;

    public int wall1X;
    public int wall2X;
    public int wall3X;

    public Vector3 pos;

    private void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        spriteR.enabled = false;

        wall1X = (int)42;
        wall2X = (int)115.8475;
        wall3X = (int)150;


    }
    private void Update()
    {

        pos = transform.position;

        if(Wall == null)
        {
            spriteR.enabled = true;
        }
        if (Wall2 == null)
        {
            spriteR.enabled = true;
        }
        //if (Wall3 == null)
        //{
        //    spriteR.enabled = true;
        //}
        else if (pos.x > wall1X && Wall2 != null)
        {
            spriteR.enabled = false;
        }
        else if (pos.x > wall2X && Wall3 != null)
        {
            spriteR.enabled = false;
        }
        if(pos.x < wall3X && pos.x > wall2X)
        {
            spriteR.enabled = false;
        }
        if(Wall3 == null && pos.x > 189)
        {
            spriteR.enabled = true;
        }
        //else if (pos.x < wall3X && pos.x > wall2X)
        //{
        //    spriteR.enabled = false;
        //}
















        //if (enemy1 == null)
        //{
        //    //spriteR.SetActive(true);
        //    spriteR.enabled = true;
        //    Debug.Log("1 is null");
        //}
        //else if(enemy2 == null && enemy1 == null)
        //{
        //    spriteR.enabled = true;    
        //}
        //else if (enemy2 == null && enemy1 == null && enemy3 == null)
        //{
        //    spriteR.enabled = true;
        //}
        //else if (pos.x > wall1X || pos.x > wall2X || pos.x > wall3X)
        //{
        //    spriteR.enabled = false;
        //}
        //else
        //{
        //    spriteR.enabled = false;
        //}


    }
}
