using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 2f;
    private Vector3 offset;

    
    void LateUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x,offset.y, offset.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
    }
}
