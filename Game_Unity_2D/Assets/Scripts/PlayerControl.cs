using UnityEngine;
using ModelsLibrary;

public class PlayerControl : MonoBehaviour
{
    private PlayerModel Player = ModelsLibrary.
    private float Speed;
    private int JumpImpuls;
    private float moveX;
    private Rigidbody2D rb;
    private bool Jump;
    private float horizontalMove;

    public Animator animator;

    void Start()
    {
        Speed = Player.Speed;
        JumpImpuls = Player.JumpImpuls;
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jump = false;
        animator.SetBool("isJumping", false);
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * Speed * Time.deltaTime);
        horizontalMove = Input.GetAxisRaw("Horizontal") * Speed;
        animator.SetFloat("spead", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpImpuls);
            Jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
            if (transform.localScale.x > 0)
            {
                animator.SetFloat("spead", Mathf.Abs(horizontalMove));
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);
            }
            else if (transform.localScale.x < 0)
                return;
        if (Input.GetKeyDown(KeyCode.D))
            if (transform.localScale.x > 0)
                return;
            else if (transform.localScale.x < 0)
            {
                animator.SetFloat("spead", Mathf.Abs(horizontalMove));
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);
            }
                
    }
}
