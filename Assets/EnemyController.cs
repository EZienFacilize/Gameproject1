﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    float fallSpeed;
    float rotSpeed;

    void Start()
    {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
    }

    void Update()
    {
        transform.Translate(-fallSpeed,0 , 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f) 
        {
            Destroy(gameObject);
        }
    }
}