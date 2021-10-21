using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    public Vector3 eulerRotation;
    public float damper;

    void Start()
    {
        transform.eulerAngles = eulerRotation;
    }

    void Update()
    {
        if (target == null)
            return;

        transform.position = Vector3.Lerp(transform.position, target.position + offset, damper * Time.deltaTime);
    }
}
