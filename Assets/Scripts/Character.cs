using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 3.0F;
    public float gravity = 10.0F;
    CharacterController controller;



    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        playerMovement();
    }

    //requirement: keyboards doesn't change the angle of the horizontal movement, 
    //Instead, we use camera(rectile pointer) to enable player to move horizontally in any angle
    void playerMovement()
    {       
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        //bind velocity with camera
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }
}

