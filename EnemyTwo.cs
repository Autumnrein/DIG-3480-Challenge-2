using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(1.54f, -2.63f);
    private Vector2 pos2 = new Vector2(7.5f, -2.63f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}