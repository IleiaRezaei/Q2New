using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject cam;
    public GameObject player;
    private float hp;
    private float maxhp;
    private GameObject bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.GetChild(1).gameObject;
        maxhp = player.GetComponent<CharacterControll>().maxHP;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cam.transform.position.x - 4.25F, 5.2F, -8);
        hp = player.GetComponent<CharacterControll>().currentHP;
        float x;
        x = (hp - 100) /25;
        bar.transform.localPosition = new Vector3(x, 0, 0);
    }
}
