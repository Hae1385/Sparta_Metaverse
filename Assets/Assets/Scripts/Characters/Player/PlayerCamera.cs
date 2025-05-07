using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;


    private void Start()
    {
        if (target == null)
            return;

        offset = transform.position - target.position;
    }

    private void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        desiredPosition.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);
    }
}
