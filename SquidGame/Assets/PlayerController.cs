using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 5.0f, 0.0f);

    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }





    }


}


//KOREAN

// using System.Collections;
// using System.Collections.Generic;

// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     public Rigidbody rb;
//     private bool moveLeft;
//     private bool moveRight;
//     private float horizontalMove;
//     public float speed = 5;
//     //public float thrust = 100.0f;

//     //private bool canJump = false;

//     public float jumpHeight = 7f;
//     public bool isGrounded;




//     // Start is called before the first frame update
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//         moveLeft = false;
//         moveRight = false;
//     }

//     public void PointerDownLeft()
//     {
//         moveLeft = true;
//     }

//     public void PointerUpLeft()
//     {
//         moveLeft = false;
//     }

//     public void PointerDownRight()
//     {
//         moveRight = true;
//     }

//     public void PointerUpRight()
//     {
//         moveRight = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         MovePlayer();
//         // if (Input.GetKeyUp(KeyCode.Space))
//         // {
//         //     canJump = true;
//         // }
//         if (isGrounded)
//         {
//             if (Input.GetKeyUp(KeyCode.Space))
//             {
//                 rb.AddForce(Vector3.up * jumpHeight);
//             }
//         }
//     }

//     void OnCollisionEnter(Collision other)
//     {
//         if (other.gameObject.tag == "Ground")
//         {
//             isGrounded = true;
//         }
//     }

//     void OnCollisionExit(Collision other)
//     {
//         if (other.gameObject.tag == "Ground")
//         {
//             isGrounded = false;
//         }
//     }
//     private void MovePlayer()
//     {
//         if (moveLeft)
//         {
//             horizontalMove = -speed;
//         }
//         else if (moveRight)
//         {
//             horizontalMove = speed;
//         }
//         else
//         {
//             horizontalMove = 0;
//         }
//     }

//     private void FixedUpdate()
//     {
//         rb.velocity = new Vector3(0, 0, horizontalMove);
//         // if (canJump)
//         // {
//         //     canJump = false;
//         //     rb.AddForce(0, 5, 0, ForceMode.Impulse);
//         // }
//     }
// }


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
// }
