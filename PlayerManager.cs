using UnityEngine;
using System.Collections;


using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    Animator anim;
    public float jumpForce;
    public float speed;
    public Text countText;
    public Text winText;
    public Text livesText;
    public Text loseText;
    public Text scoreText;
    private Rigidbody2D rb2d;
    private int count;
    private int lives;
    private int score;
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();

        musicSource.clip = musicClipOne;

        score = 0;
        count = 0;
        lives = 3;
        loseText.text = "";
        winText.text = "";
        SetAllText();

    }

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 1);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetInteger("State", 0);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 1);

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetInteger("State", 0);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetInteger("State", 2);

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetInteger("State", 0);

        }




    }



    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");


        float moveVertical = Input.GetAxis("Vertical");


        Vector2 movement = new Vector2(moveHorizontal, moveVertical);


        rb2d.AddForce(movement * speed);


    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {


            if (Input.GetKey(KeyCode.UpArrow))
            {

                rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }

        }

    }




    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {

            other.gameObject.SetActive(false);


            count = count + 1;
            score = score + 1;

            SetAllText();
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            score = score - 1; 
            lives = lives - 1;
            SetAllText();
        }

        if (count == 4)
        {
            transform.position = new Vector2(-202f, -2.32f);
            lives = 3;
            SetAllText();
            

        }
 
       

    }


    void SetAllText()
    {
        scoreText.text = "Score: " + score.ToString();
        countText.text = "Count: " + count.ToString();
        livesText.text = "Lives: " + lives.ToString();
        if (count >= 8)
        {
            winText.text = "You Win!";
            musicSource.clip = musicClipTwo;



        }
        if (lives == 0)
        {
            Destroy(this.gameObject);
            loseText.text = "You Lose!";
        }
    }
}
