using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] public static int JumpCount = 10;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            JumpCount--;
        }
        if(JumpCount == 0)
        {
            Restart();
        }


    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Restart();
        }

    }
    static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        JumpCount = 10;
    }
}
