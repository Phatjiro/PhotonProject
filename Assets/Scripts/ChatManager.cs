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
    public Button btnMinimize;
    public GameObject scrollView;

    void Start()
    {
        btnSend.onClick.AddListener(SendMessage);
        btnMinimize.onClick.AddListener(MinimizeChat);
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

    public void MinimizeChat()
    {
        if (scrollView.GetComponent<RectTransform>().anchoredPosition.y > -160)
        {
            scrollView.GetComponent<RectTransform>().anchoredPosition = new Vector2(-238f, -160);
            scrollView.GetComponent<RectTransform>().sizeDelta = new Vector2(205.85f, 18);
        }
        else
        {
            scrollView.GetComponent<RectTransform>().anchoredPosition = new Vector2(-238f, -28);
            scrollView.GetComponent<RectTransform>().sizeDelta = new Vector2(205.85f, 200);
        }
    }
}
