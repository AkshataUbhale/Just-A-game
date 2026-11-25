using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MovementSpeed = 5f;
    [SerializeField] float JumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    [SerializeField] AudioSource JumpSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(moveHorizontal * MovementSpeed, rb.velocity.y, moveVertical * MovementSpeed);

       if (Input.GetButtonDown("Jump")&& IsGrounded())
        {
            Jump();

        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
        JumpSound.Play();
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Head")) { 
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
        //IN the future, you can use this function to check if the player is grounded before allowing them to jump.
        // the second parameter is the radius of the sphere, you can adjust it to fit your needs.
        //the groundCheck is a transform that you can place at the bottom of your player to check if they are grounded.
    }
}
