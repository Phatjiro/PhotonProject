using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public Text textRoomName;
    public Text textPlayerCount;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(JoinRoom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinRoom()
    {
        GameObject.Find("PhotonManager").GetComponent<PhotonManager>().JoinRoomInList(textRoomName.text);
    }
}
