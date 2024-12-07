using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.3f;
    Vector3 speed;

    void LateUpdate()
    {
        if(target.position.y > transform.position.y)
        {
            Vector3 targetPos = new Vector3(0f, target.position.y, -10f);
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref speed, smoothSpeed*Time.deltaTime);//（当前位置，目标位置，保持平滑移动的速率？，速度）
        }
    }
}
