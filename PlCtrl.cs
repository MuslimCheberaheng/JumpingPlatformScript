using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlCtrl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float move;
    public  float speed;
    public GameObject player;
    private BoxCollider2D BoxCol;
    public float jumpingHeight;
    public LinkScene linkScene;
    private float TopScore = 0.0f;    
    public Text scoreText;        
    SpriteRenderer SRflip;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SRflip = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        BoxCol = GetComponent<BoxCollider2D>();        
    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        
        if(rb.velocity.y > 0 && transform.position.y > TopScore)
        {
            TopScore = transform.position.y;
        }
        scoreText.text = "Score" + Mathf.Round(TopScore).ToString(); //score++ (no limit, no max score)

        if(Input.GetKey(KeyCode.A))
        {
            SRflip.flipX = true;
        }
        if(Input.GetKey(KeyCode.D))
        {
            SRflip.flipX = false;
        }
        anim.SetInteger("PlayerCondition", 0);        

        if(player.transform.position.y <= -50) //Player Fall down = dead
        {
            linkScene.LoadScene("DeadScene");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform" || rb.velocity.y <= 0)
        {
            anim.SetInteger("PlayerCondition", 1);

            StartCoroutine(SetDelay());
            rb.AddForce(Vector2.up * jumpingHeight); //auto jumping when touching the platform            
        }
        if (collision.gameObject.tag == "Trap")
        {
            StartCoroutine(SetDelay());
            linkScene.LoadScene("DeadScene");
        }
    }
    
    IEnumerator SetDelay()
    {
        yield return new WaitForSeconds(3);
    }
}
