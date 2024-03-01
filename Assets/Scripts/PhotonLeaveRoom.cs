using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhotonLeaveRoom : MonoBehaviourPunCallbacks
{
    public Button btnLeaveRoom;

    // Start is called before the first frame update
    void Start()
    {
        btnLeaveRoom.onClick.AddListener(LeaveRoom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeaveRoom()
    { 
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene("LobbyScene");
    }
}
