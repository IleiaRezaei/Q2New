using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoEnemy : MonoBehaviour
{

    //public Sprite sprite1;
    //public Sprite sprite2;


    private SpriteRenderer spriteRenderer;

    private Animator anim_potato;
    public bool isAttacking;

    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
        //spriteRenderer = GetComponent<SpriteRenderer>();
        
        //spriteRenderer.sprite = sprite2;
        

        anim_potato = GetComponent<Animator>();

        isAttacking = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isAttacking == true)
        {
            anim_potato.SetBool("isAttacking", true);
            //anim_potato.Play("GPBite");

        }
        if (isAttacking == false)
        {
            anim_potato.SetBool("isAttacking", false);
            //anim_potato.Play("GPWalk");

        }

        
    }

    //void ChangeColor()
    //{
    //   if(spriteRenderer.sprite == sprite1)
    //    {
    //        spriteRenderer.sprite = sprite2;
    //    }
    //    else
    //    {
    //       spriteRenderer.sprite = sprite1;
    //    }
    //}

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(":::::::::::::::::::::" + collision.gameObject.tag);
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("isAttacking");
            isAttacking = true;

            anim_potato.SetBool("isAttacking", true);

        }
        else        
        {
            //Debug.Log("notAttacking");
            //anim_potato.SetBool("isAttacking", false);

        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        isAttacking = false;
        Debug.Log("notAttacking");
        anim_potato.SetBool("isAttacking", false);

        anim_potato.SetBool("animationHasStopped", true);

        Debug.Log("==========================================");

    }

}
