using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController2D controller;
    private Animator anim;
    private float horizontalMove=0f;
    [SerializeField]
    private float runSpeed;
    private bool jump=false;
    private bool crouch = false;
    private static Rigidbody2D rb;

    public object GameHandler { get; private set; }

    private void Awake()
    {
        controller = GetComponent<CharacterController2D>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      //  anim.SetFloat("walk", Input.GetAxisRaw("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {

            anim.SetBool("jump", true);
            jump = true;
        }
    }

    
    public void Move(float horizontal)
    {
        horizontalMove = horizontal * runSpeed;
    }
    public void stopMove()
    {
        horizontalMove = 0f;
    }
    public void Jump()
    {
        jump = true;
    }

    public void upStairs()
    {
        rb.AddForce(Vector2.up*500);
    }

    public static void invertGravity()
    {
        rb.gravityScale *= -1;
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Equals("Stairs"))
        {
            Gamehandler.changeActionButton(() => upStairs());
          
        }

        if (collision.name.Equals("Gravity"))
        {
            Gamehandler.changeActionButton(() => invertGravity());
        }
        //return "";
    }
    public void OnPointerDownDelegate(PointerEventData data)
    {
        //Debug.Log("yaya");
        upStairs();
    }

}
