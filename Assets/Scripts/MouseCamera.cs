using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviourPunCallbacks
{
    public Vector2 turn;
    public float sensitivity = 3f;
    public Vector3 deltaMove;
    public float speed = 5f;
    public GameObject mover;
    public GameObject cameraPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       /* if (GetComponent<PhotonView>().IsMine == true)
        {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;
            turn.y += Input.GetAxis("Mouse Y") * sensitivity;
            mover.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
            cameraPlayer.transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);

            deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
            mover.transform.Translate(deltaMove);
        }*/
    }
}
