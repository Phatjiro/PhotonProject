using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomList : MonoBehaviourPunCallbacks
{
    public GameObject pretabRoom;
    public GameObject[] allRooms;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        base.OnRoomListUpdate(roomList);
        for (int i = 0; i < allRooms.Length; i++)
        {
            if (allRooms[i] != null)
            {
                Destroy(allRooms[i]);
            }
        }

        allRooms = new GameObject[roomList.Count];

        for (int i = 0; i < roomList.Count; i++)
        {
            if (roomList[i].IsOpen && roomList[i].IsVisible && roomList[i].PlayerCount >= 1)
            {
                GameObject room = Instantiate(pretabRoom, Vector3.zero, Quaternion.identity, GameObject.Find("Content").transform);
                room.GetComponent<Room>().textRoomName.text = roomList[i].Name;
                room.GetComponent<Room>().textPlayerCount.text = roomList[i].PlayerCount + "/" + roomList[i].MaxPlayers;

                allRooms[i] = room;
            }
        }
    }
}
