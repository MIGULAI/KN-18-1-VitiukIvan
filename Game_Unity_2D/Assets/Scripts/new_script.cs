using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_script : MonoBehaviour
{
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
    }
}
