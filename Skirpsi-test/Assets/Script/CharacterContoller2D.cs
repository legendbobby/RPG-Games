﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterContoller2D : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] public float speed = 7f;
    Vector2 motionVector;
    public Vector2 lastMotionVector;
    Animator animator;
    public bool moving;
    public static bool enableMovement= true;
    DialogueManager dialogueManager;
    PSolving pSolving;
    public Vector2 lagijalan;
    Comp_Sys comp_Sys;
    

    private void Start()
    {
        dialogueManager = GameManager.instance.dialogueManager;
        pSolving = GameManager.instance.psolving;
        comp_Sys = GameManager.instance.comp_Sys;
    }

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    private void Update()
    {
      
        if (dialogueManager.ngomong == true|| pSolving.pspanel == true || comp_Sys.pc_panel== true)
        {
            speed = 0f;
        }
        if (dialogueManager.ngomong == false || pSolving.pspanel == false || comp_Sys.pc_panel == false)
        {
            speed = 7f;
        }


        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        motionVector = new Vector2(
            horizontal,
            vertical
            );
        animator.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("vertical", Input.GetAxisRaw("Vertical"));

        moving = horizontal != 0 || vertical != 0;
        animator.SetBool("moving", moving);

        if (horizontal != 0 || vertical != 0)
        {
            lastMotionVector = new Vector2(
                horizontal,
                vertical
                ).normalized;
            animator.SetFloat("lastHorizontal", horizontal);
            animator.SetFloat("lastVertical", vertical);
        }
        lagijalan = rigidbody2d.velocity;
    }
    void FixedUpdate()
    {
        if (enableMovement)
        {
            Move();
        }
        
    }

    private void Move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}
