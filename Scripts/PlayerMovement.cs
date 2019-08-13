using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public GameObject deathAnimation;

    public float runSpeed = 40f;

    public float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public bool move = true;


    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            }
            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
        
    }

    void FixedUpdate()
    {
        //Move Character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
    //DeathMethod called by RIP
    public void Die()
    {
        Instantiate(deathAnimation, gameObject.transform.position, gameObject.transform.rotation);
        
        gameObject.SetActive(false);     
    }

}
