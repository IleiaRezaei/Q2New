using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotatoExplosion : MonoBehaviour
{
    public int explosionDamage = 100;
    public bool isExploding;

    private SpriteRenderer spriteRenderer;

    private Animator animRedPot;

    private Rigidbody2D RigidBoy;

    public bool held;

    public GameObject child;
    public GameObject me;

    private IEnumerator coroutine;

    public int waitFor;

    public bool die;
    public bool ding;

    private AudioSource aud;
    public AudioClip explo;

    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        RigidBoy = GetComponent<Rigidbody2D>();

        animRedPot = GetComponent<Animator>();

        isExploding = false;
        //anim_RedPot.SetBool("RedExplode", false);
        //StartCoroutine(WaitForSeconds());
        //StartCoroutine(waituntilExplode());

    }

    // Update is called once per frame
    void Update()
    {
        if (isExploding == true)
        {
            if (ding)
            {
                aud.clip = explo;
                aud.Play();
            }

            //anim_RedPot.Play("Explosion");
            //animRedPot.SetBool("Explode", true);
            animRedPot.SetBool("ex", true);
            animRedPot.SetBool("hasWaited", true);
            GetComponent<Rigidbody2D>().freezeRotation = true;
            StartCoroutine("WaitForSeconds");
            //WaitForSeconds();
        }
        if (die)
        {
            //waituntilExplode();
            Destroy(me);
        }
        //Debug.Log(isExploding);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("--------------------------hit" + collision.gameObject.tag);
        if (collision.gameObject.tag == "PlayerAttack")
        {
            Debug.Log("Hi---------");

            isExploding = true;
            WaitForSeconds();
            //animRedPot.SetBool("Explode", true);
            //anim_RedPot.SetBool("Explode", true);
            //animRedPot.Play("Explosion");
            //animRedPot.SetBool("isAttacking", false);

            //yield return new WaitForSeconds(5);
            //Debug.Log("))))))))))((((((((((((((((())))))))))))))((((((((((((((((((((ANIMATIONPLAYED");
            //waituntilExplode();

        }


        if (collision.gameObject.tag == "PlayerAttack")
        {
            if(held == false) {
                if (collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding != true)
                {
                    RigidBoy.angularVelocity = 0;
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    held = true;
                    gameObject.layer = 9;
                    GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    GetComponent<Rigidbody2D>().freezeRotation = false;
                    RigidBoy.drag = 5;
                    RigidBoy.angularDrag = 0.5F;
                    collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().heldobj = this.gameObject;
                    collision.gameObject.transform.parent.gameObject.GetComponent<CharacterControll>().holding = true;
                    isExploding = true;
                }
            }
        }
        else
        {
            //tag = "Untagged";
        }
        if (collision.gameObject.tag == "Ball")
        {
            animRedPot.SetBool("HitByBall", true);
        }
    }
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds((int)3.1);
        child.SetActive(true);
    }

    //IEnumerator waituntilExplode()
    //{
    //    yield return new WaitForSeconds(5);l

    //}
}
