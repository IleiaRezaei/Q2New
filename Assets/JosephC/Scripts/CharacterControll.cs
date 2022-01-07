using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    private float MoveSpeed = 5000;
    private float MaxSpeed = 5000;
    private Rigidbody2D RigidBoy;
    private CircleCollider2D Coli;
    private Vector2 Direction = new Vector2(1, 0);
    private CapsuleCollider2D hitbox;
    private Animator anim_player;
    public bool attacking = false;
    private bool Dashing = false;


    public int maxHP = 100;
    public int currentHP = 100;

    public object[,] text;

    public int damage = 0;
    public Vector2 knockback;

    public int playerKnockback = 0;

    public GameObject texbox;
    private RaycastHit2D intercast;
    private float dashtimer;
    private bool CanDash = false;
    private SpriteRenderer sprt;
    private ParticleSystem part;

    public LayerMask lm;
    // Start is called before the first frame update
    void Start()
    {
        text = new object[,] { { "testtext", "neutral", false }, { "testtext", "neutral", true } };
        RigidBoy = GetComponent<Rigidbody2D>();
        Coli = GetComponent<CircleCollider2D>();
        hitbox = transform.GetChild(0).GetComponent<CapsuleCollider2D>();
        anim_player = GetComponent<Animator>();
        sprt = GetComponent<SpriteRenderer>();
        part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP == 0)
        {
            Destroy(this);
        }

        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }

        float movex = (Input.GetAxis("Horizontal"));
        float movey = (Input.GetAxis("Vertical"));
        if (new Vector2(movex, movey) != new Vector2(0, 0))
        {
            intercast = Physics2D.Raycast(transform.position, new Vector2(movex, movey), 2, lm);

            if (attacking == false && Dashing == false)
            {
                if (part.isEmitting != true)
                {
                    part.Play(true);
                }

                Direction = new Vector2(movex, movey);
                anim_player.Play("Walk");
            }
            else
            {
                part.Stop(true);
            }
        }
        else
        {
            part.Stop(true);
            if (attacking == false && Dashing == false)
            {
                anim_player.Play("Idle");
            }

        }
        if (Dashing == false)
        {
            if (CanDash == false)
            {
                dashtimer -= Time.deltaTime;
                print(dashtimer);
            }
            if (dashtimer <= 0)
            {
                CanDash = true;
                Color col = new Color(1, 1, 1, 1);
                sprt.color = col;
            }
        }
        else
        {
            anim_player.Play("Dash");
            dashtimer -= Time.deltaTime;
            if (dashtimer <= 0)
            {
                Dashing = false;

                dashtimer = 0.5F;
            }
        }
        if (attacking == false && Dashing == false)
        {
            knockback = new Vector2();
            damage = 0;
            RigidBoy.AddForce(new Vector2(movex, movey) * MoveSpeed * Time.deltaTime);

        }
        if (attacking)
        {
            RigidBoy.velocity = new Vector2(0, 0);
        }
        if (Direction.x > 0)
        {
            hitbox.offset = new Vector2(0.5F, hitbox.offset.y);
            sprt.flipX = false;
        }
        if (Direction.x < 0)
        {
            sprt.flipX = true;
            hitbox.offset = new Vector2(-0.5F, hitbox.offset.y);
        }
        if (Input.GetButtonDown("Jump") && CanDash)
        {
            Color col = new Color(0.8F, 0.8F, 0.8F, 0.8F);
            sprt.color = col;
            Dashing = true;
            RigidBoy.velocity = Direction * 75F;
            dashtimer = 0.3F;
            CanDash = false;

        }
        if (attacking == false && Dashing == false)
        {
            if (Input.GetButtonDown("Light"))
            {
                damage = attack(false);
                anim_player.Play("LightAtk");
            }
            if (Input.GetButtonDown("Heavy"))
            {
                damage = attack(true);
                anim_player.Play("HeavyAtk");
            }
        }
        if (intercast.collider != null && intercast.collider.tag != "Player")
        {
            if (intercast.collider)
            {
                if (Input.GetButtonDown("interact"))
                {
                    NPC npcscripy = intercast.collider.GetComponent<NPC>();
                    textbox texscrp = texbox.GetComponent<textbox>();
                    texscrp.DoText(npcscripy.InterAct(), npcscripy.geticons(), npcscripy);
                }
            }
        }
        Debug.DrawRay(transform.position, Direction * 2, Color.yellow);

    }

    int attack(bool heavy)
    {
        if (attacking == false)
        {
            if (heavy)
            {
                print("heavy");
                attacking = true;
                knockback = Direction * 350;
                return 69;

            }
            else
            {
                print("light");
                hitbox.enabled = true;
                attacking = true;
                knockback = Direction * 200;
                return 40;

            }
        }
        return damage;

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Dashing == false)
        {


            if (collision.gameObject.tag == "regularBean")
            {
                currentHP += 20;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "EnemyAttack")
            {
                print(collision);
                currentHP -= 20;
                RigidBoy.velocity = Direction * -50F;

            }
        }

    }
    public void OnKnock(Vector2 knock)
    {
        RigidBoy.AddForce(knock);
    }
}
