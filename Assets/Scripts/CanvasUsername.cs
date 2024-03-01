using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasUsername : MonoBehaviour
{
    public TextMeshProUGUI tmpUsername;

    private void LateUpdate()
    {
        tmpUsername.transform.rotation = Quaternion.LookRotation(Vector3.forward);
    }
}
