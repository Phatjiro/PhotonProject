using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public InputField inputMessage;
    public GameObject messagePrefab;
    public GameObject content;
    public Button btnSend;

    void Start()
    {
        btnSend.onClick.AddListener(SendMessage);
    }

    public void SendMessage()
    {
        GetComponent<PhotonView>().RPC("GetMessage", RpcTarget.All, inputMessage.text);
        Debug.Log("Send goood!");
    }

    [PunRPC]
    public void GetMessage(string receiveMessage)
    {
        GameObject mess = Instantiate(messagePrefab, Vector3.zero, Quaternion.identity, content.transform);
        mess.GetComponent<Message>().textMessage.text = receiveMessage;
    }
}
