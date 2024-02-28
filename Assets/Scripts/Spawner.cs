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
        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(Random.Range(-8, 8), -1.5f, 0), Quaternion.identity);
        player.GetComponent<CharacterMovement>().mark.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
