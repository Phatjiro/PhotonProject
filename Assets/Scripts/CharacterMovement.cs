using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject mark;
    private Vector3 movementDirection;
    public Rigidbody rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (GetComponent<PhotonView>().IsMine == true)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 30f);
            }


            rb.MovePosition(rb.position + movementDirection * speed * Time.fixedDeltaTime);
            
            
            float Speed = new Vector2(horizontalInput, verticalInput).magnitude;

            if (Speed > 0.1f)
            {
                anim.SetFloat("Blend", Speed, 0.3f, Time.deltaTime);
            }
            else if (Speed < 0.1f)
            {
                anim.SetFloat("Blend", Speed, 0.15f, Time.deltaTime);
            }
        }
    }
}
