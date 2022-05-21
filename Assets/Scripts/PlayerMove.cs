using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    public bool onStartButtonClick = false;

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (onStartButtonClick)
        {
            float xDirection = Input.GetAxis("Horizontal");
            float zDirection = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
            transform.position += moveDirection * speed;

            if (moveDirection != Vector3.zero)
            {
                transform.forward = moveDirection;
            }
        }
    }

    public void AllowPlayerMovement()
    {
        onStartButtonClick = true;
    }
}
