using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySix : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-203.63f, 4.42f);
    private Vector2 pos2 = new Vector2(-201.48f, 4.42f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}