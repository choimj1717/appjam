using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(1, 2, -5);
    public float rotationSpeed = 5.0f;
    public float smoothSpeed = 0.125f;

    private float pitch = 0.0f; // 피치
    private float yaw = 0.0f; // 요 

    void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * rotationSpeed;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed;
        pitch = Mathf.Clamp(pitch, -30f, 60f); // 각도 제한

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

        Vector3 desiredPosition = target.position + rotation * offset;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        Vector3 lookAtTarget = target.position + Vector3.up * 1.5f;
        transform.LookAt(lookAtTarget);
    }
}
