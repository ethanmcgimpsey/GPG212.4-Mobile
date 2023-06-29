using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the player moves sideways

    private bool isMoving = false; // Flag to check if the player is currently moving

    private void Update()
    {
        if (Input.touchCount > 0) // Check if there is at least one touch input on the screen
        {
            Touch touch = Input.GetTouch(0); // Get the first touch input

            /*if (touch.phase == TouchPhase.Began) // Check if the touch just started
            {
                isMoving = true; // Set the flag to indicate that the player is moving
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isMoving = false; // Set the flag to indicate that the player has stopped moving
            }*/
            Vector3 movement = new Vector3(1f, 0f, 0f);
            if (touch.position.x > Screen.width / 2)
            {
                transform.Translate(movement * moveSpeed * Time.fixedDeltaTime);
            }
            else if (touch.position.x <= Screen.width / 2)
            {
                transform.Translate(movement * -moveSpeed * Time.fixedDeltaTime);
            }
        }

        Mathf.Clamp(transform.position.x, -1.83f, 1.83f);
    }

    private void FixedUpdate()
    {
        //if (isMoving)
        //{
        //    float horizontalMovement = Input.acceleration.x; // Get the horizontal movement from the accelerometer

        //    Vector3 movement = new Vector3(horizontalMovement, 0f, 0f); // Create a movement vector

        //    transform.Translate(movement * moveSpeed * Time.fixedDeltaTime); // Move the player sideways
        //}
    }
}
