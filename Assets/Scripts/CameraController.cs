using Cinemachine;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    PhotonView photonView;

    [SerializeField]
    CinemachineVirtualCamera cam;

    [SerializeField]
    Transform player;
    void Start()
    {
        if (photonView.IsMine)
        {
            cam.gameObject.SetActive(true);
            cam.GetComponent<CameraFollower>().SetTarget(player);
        }
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetMouseButton(1))
            {
                float mouseX = Input.GetAxis("Mouse X");
                transform.GetChild(0).RotateAround(transform.position, Vector3.up, mouseX);
            }
        }
    }
}
