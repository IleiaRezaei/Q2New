using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class boss : MonoBehaviour
{
    public int hp = 200;
    public int attack = 0;
    public bool dead;
    public bool attacking;
    private Animator anim;
    public float timer;
    private int lastattack;
    public bool go;
    public GameObject redpotat;
    public GameObject greenpotat;
    public GameObject slime;
    public bool roll;
    public GameObject[] enmys;
    public bool on;
    private int es;
    private AudioSource aud;
    public AudioClip puke;
    public AudioClip yell;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            SceneManager.LoadScene("FinalCutscene");
        }
        if(dead == false && on) {
        if (roll)
        {
            if (GameObject.FindGameObjectsWithTag("slime").Length == 0 && GameObject.FindGameObjectsWithTag("Ben").Length == 0)
            {
                attack = 0;
                roll = false;
            }
        }
        if(attack == 0)
        {
            
            go = false;
            if(timer >= 2)
            {
                attack = Random.Range(1,3);
                timer = 0;
            }
            else
            {
                anim.Play("idle");
                timer += Time.deltaTime;
            }
        }
        if(attack == 1)
        {
            if (go == false)
            {
                aud.clip = yell;
                aud.Play();
                anim.Play("roar");
                GameObject obj1 = Instantiate(greenpotat, new Vector3 (transform.position.x + 5,0,0), Quaternion.Euler(0, 0, 0));
                obj1.tag = "Ben";
                GameObject obj2 = Instantiate(redpotat, new Vector3(transform.position.x -5, 0, 0), Quaternion.Euler(0, 0, 0));
                roll = true;
                go = true;
                
            }
        }
            if (attack == 2)
            {
                if (go == false)
                {
                    aud.clip = puke;
                    aud.Play();
                    anim.Play("attack");
                    GameObject obj1 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 0));
                    obj1.GetComponent<slime>().move = true;
                    obj1.tag = "slime";
                    GameObject obj2 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, 45));
                    obj2.GetComponent<slime>().move = true;
                    obj2.tag = "slime";
                    GameObject obj3 = Instantiate(slime, transform.position, Quaternion.Euler(0, 0, -45));
                    obj3.GetComponent<slime>().move = true;
                    obj3.tag = "slime";
                    roll = true;
                    go = true;
                }

            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RedPotatoDamage")
        {
            hp -= 40;
            anim.Play("hurt");
            if (hp <= 0)
            {
                
                dead = true;
            }
        }
    }
}
