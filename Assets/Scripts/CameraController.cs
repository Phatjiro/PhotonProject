using Cinemachine;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviourPunCallbacks
{
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetMouseButton(1))
            {
                float mouseX = Input.GetAxis("Mouse X");
                transform.RotateAround(transform.position, Vector3.up, mouseX);
            }
        }
    }
}
