using System;
using UnityEngine;

public class CameraFolloving : MonoBehaviour
{
    [SerializeField] private Transform folloverTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Single lerpForce;

    private void LateUpdate()
    {
        transform.position = folloverTransform.position + offset;
    }
}
