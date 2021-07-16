using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public Animator animator;
    bool jump = false;
    // Start is called before the first frame update

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
       
        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
        
    }

  public  void OnLanding()
    {
        jump = false;
        animator.SetBool("IsJumping", false);
 
    }

    private void FixedUpdate()
    {
    controller.Move(horizontalMove* Time.fixedDeltaTime, false, jump);

    }
}
