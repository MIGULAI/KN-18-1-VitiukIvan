using System;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Control : MonoBehaviour
{
    public LayerMask groundlayerMask;
    public float speed = 20f;
    private Rigidbody2D rb;
    private CircleCollider2D cc;
    public Animator animator;
    public float spead = 20f;
    public float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;
    private float buf;
    private float bufOne = 0f;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = false;
        animator.SetBool("isJumping", false);
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        buf = rb.velocity.y - bufOne;
        bufOne = rb.velocity.y;
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        horizontalMove = Input.GetAxisRaw("Horizontal") * spead;

        animator.SetFloat("spead", Mathf.Abs(horizontalMove));
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 8000);
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
            if (transform.localScale.x > 0)
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);
            else if (transform.localScale.x < 0)
                return;
        if (Input.GetKeyDown(KeyCode.D))
            if (transform.localScale.x > 0)
                return;
            else if (transform.localScale.x < 0)
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
