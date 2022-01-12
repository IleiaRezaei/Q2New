using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoEnemy : MonoBehaviour
{

    //public Sprite sprite1;
    //public Sprite sprite2;

    public GameObject me;
    public GameObject player;
    public GameObject seekerPP;


    private Vector3 directionBetween; 

    private SpriteRenderer spriteRenderer;

    private Animator anim_potato;
    public bool isAttacking;

    public Transform target;

    public CapsuleCollider2D hitbox;
    public Rigidbody2D RigidBoy;

    public Vector2 knock;

    // Start is called before the first frame update
    void Start()
    {
        RigidBoy = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        
        //spriteRenderer.sprite = sprite2;
        

        anim_potato = GetComponent<Animator>();

        isAttacking = false;
        hitbox = transform.GetChild(0).GetComponent<CapsuleCollider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        directionBetween = me.transform.position - player.transform.position;

        knock = directionBetween.normalized * -5000;
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
        if(directionBetween.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        if (directionBetween.x > 0)
        {
            spriteRenderer.flipX = false;
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
            Debug.Log("++++++++++++++++++++++++++++isAttacking++++++++++++++++++++++++++++");
            isAttacking = true;

            anim_potato.SetBool("isAttacking", true);

            hitbox.enabled = true;
        }
        if(collision.gameObject.tag == "PlayerAttack")
        {
            isAttacking = false;

            Debug.Log("|||||||||||||||||||||||||||||||||||||isGettingAttacked|||||||||||||||||||||||||||||||||||");


            Vector2 kbf = player.GetComponent<CharacterControll>().knockback;
            Debug.Log("KBF:::::::" + kbf.x + "    " + kbf.y);
            //collision.gameObject.GetComponent<CharacterControll>().k = knock;
            //RigidBoy.AddForce(player.GetComponent<CharacterControll>().Direction * player.GetComponent<CharacterControll>().knockback);
            //RigidBoy.AddForce(player.GetComponent<CharacterControll>().knockback);
            RigidBoy.AddForce(new Vector2(150000000, 0));


        }
    }

    
    void OnTriggerExit2D(Collider2D collision)
    {
        isAttacking = false;
        Debug.Log("notAttacking");
        anim_potato.SetBool("isAttacking", false);

        anim_potato.SetBool("animationHasStopped", true);

        Debug.Log("==========================================");

        hitbox.enabled = false;
    }

    public void OnKnock(Vector2 knock)
    {
        //hi
    }

    IEnumerable DisableScript()
    {
        seekerPP.GetComponent<AIDestinationSetter>().enabled = false;

        yield return new WaitForSeconds(3f);

        seekerPP.GetComponent<AIDestinationSetter>().enabled = true;

    }
}