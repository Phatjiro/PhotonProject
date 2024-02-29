using Cinemachine;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = PhotonNetwork.Instantiate("PlayerObject", new Vector3(Random.Range(-8, 8), -1.5f, 0), Quaternion.identity);
        player.transform.Find("Player").GetComponent<CharacterMovement>().mark.SetActive(true);
        player.transform.Find("Player").GetComponent<MouseCamera>().cameraPlayer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
