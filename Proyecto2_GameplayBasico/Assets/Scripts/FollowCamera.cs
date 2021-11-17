using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 25, 0);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
