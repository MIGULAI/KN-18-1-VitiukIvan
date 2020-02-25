using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_script : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float spead = Player_Model.Model.Spead;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * spead;

        animator.SetFloat("spead", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
