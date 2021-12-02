﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(target.position.x , target.position.y , transform.position.z);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        if(transform.position != target.position)
        {
            transform.position = Vector3.Lerp(transform.position , targetPosition , smoothing);
        }
    }
}
