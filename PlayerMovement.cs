using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    private Vector2 movement;
    private Rigidbody2D rigidbody;

    private Animator anim;
    private float horizontal = 0.0f;
    private float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        horizontal = movement.x > 0.01 ? movement.x : movement.x < -0.01 ? 1 : 0;
        speed = movement.y > 0.01 ? movement.y : movement.y < -0.01 ? 1 : 0;

        if(movement.x < -0.01){
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else{
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", speed);
    }

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

}
