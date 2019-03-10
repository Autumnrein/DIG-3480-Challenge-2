using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeven : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-192.45f, -2.66f);
    private Vector2 pos2 = new Vector2(-198.51f, -2.66f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}

