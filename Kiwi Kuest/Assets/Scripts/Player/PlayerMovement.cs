using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public CharacterController controller;
    public GameObject playerGraphics;

    private Vector3 moveDirection;
    private Vector3 lastDirection;

    public PlayerAnimations playerAnimations;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    void FixedUpdate()
    {
        float yDir = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxisRaw("Vertical") * moveSpeed) + (transform.right * Input.GetAxisRaw("Horizontal") * moveSpeed);      //Gets axis inputs for movemnt
        moveDirection = moveDirection.normalized * moveSpeed;   //Normalizes the input
        moveDirection.y = yDir;

        if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            lastDirection = moveDirection;
            playerAnimations.isWalking = true;
        }else
        {
            playerAnimations.isWalking = false;
        }

        controller.Move(moveDirection * Time.deltaTime);

        playerGraphics.transform.rotation = Quaternion.LookRotation(lastDirection);
        playerAnimations.AnimationTrigger();
    }

}
/*
 * The reason that Movement is done in the Fixed Update is because the "Update" Function is not always good for physics calculation
 * What is its good for however is handling inputs, so it becomes the input. Since Fixed Update is after Update and since the movement is
 *      multipliyed by fixedDeltaTime, it will give a much more consinstant movement; 
 */
