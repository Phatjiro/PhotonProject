using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform targetFollow;
    Vector3 offset;
    public void SetTarget(Transform t)
    {
        targetFollow = t;
        offset = new Vector3(0, 3, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (targetFollow != null)
        {
            this.transform.position = targetFollow.position+offset;
        }
    }
}
