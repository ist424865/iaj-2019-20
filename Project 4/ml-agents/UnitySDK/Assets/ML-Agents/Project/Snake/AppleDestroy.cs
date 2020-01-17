﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroy : MonoBehaviour
{
    public const float DEFAULT_HEIGHT = 0.0f;
    void OnCollisionEnter(Collision collision)
    {
        gameObject.transform.position = new Vector3(Random.Range(-7.0f, 7.0f), DEFAULT_HEIGHT, Random.Range(-7.0f, 7.0f));
    }
 
}