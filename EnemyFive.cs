using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFive : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-196.47f, -0.62f);
    private Vector2 pos2 = new Vector2(-194.46f, -0.62f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
