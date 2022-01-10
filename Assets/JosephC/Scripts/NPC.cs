using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string[] text;
    public Sprite[] icons;
    private ParticleSystem partic;


    private void Start()
    {
        partic = GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public string[] InterAct()
    {
        return text;
    }
    public Sprite[] geticons()
    {
        return icons;
    }
    public void End()
    {
        partic.Stop();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            if(collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding != true)
            {
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().heldobj = this.gameObject;
                collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding = true;
            }
        }
    }
}
