using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public GameObject Wall;
    public GameObject Wall2;
    public GameObject[] Enemy;
    public int wallCount;
    //public List<GameObject> E;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //E.Add(Wall);
    }

    // Update is called once per frame
    void Update()
    {

        wallCount = 0;
        foreach(GameObject e in Enemy)
        {  
           
            if(e != null)
            {
                wallCount++;
            }
        }
        if (wallCount <= 4)
        {
            Destroy(Wall);
        }
        if (wallCount <= 0)
        {
            Destroy(Wall2);
        }
    }
}
