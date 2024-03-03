using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI tmpCharacterName;
    public SkillManager skillManager;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<PhotonView>().IsMine == false)
        {
            tmpCharacterName.gameObject.SetActive(true);
            tmpCharacterName.SetText(GetComponent<PhotonView>().Controller.NickName);
            tmpCharacterName.color = Color.red;
        }
        else
        {
            tmpCharacterName.gameObject.SetActive(true);
            tmpCharacterName.SetText(GetComponent<PhotonView>().Controller.NickName);
            tmpCharacterName.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        { 
            skillManager.UseSuperSkill();
        }
    }
}
