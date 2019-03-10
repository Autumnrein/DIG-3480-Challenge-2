﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFour : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-6.0f, -2.67f);
    private Vector2 pos2 = new Vector2(-3.0f, -2.67f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
