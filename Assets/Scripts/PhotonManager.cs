using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    public Text textLoading;
    public Button btnCreateRoom;
    public Button btnJoinRoom;
    public InputField inputRoomName;
    public Text textState;
    public InputField inputUsername;

    // Start is called before the first frame update
    void Start()
    {
        btnCreateRoom.onClick.AddListener(CreateRoom);
        btnJoinRoom.onClick.AddListener(JoinRoom);

        // Connect to Photon Server
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        // Join to lobby if connect to server successful
        PhotonNetwork.JoinLobby();
        textLoading.text = "Joined to Lobby";
    }

    public void CreateRoom()
    { 
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;

        PhotonNetwork.CreateRoom(inputRoomName.text, roomOptions);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(inputRoomName.text);
    }

    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
        textState.text = "In room - " + PhotonNetwork.CurrentRoom.Name;
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        Debug.Log(message);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        textState.text = "In room - " + PhotonNetwork.CurrentRoom.Name;
        PhotonNetwork.NickName = inputUsername.text;
        PhotonNetwork.LoadLevel("PlayScene");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        Debug.Log(message);
    }

    public void JoinRoomInList(string roomName)
    { 
        PhotonNetwork.JoinRoom(roomName);
    }
}
