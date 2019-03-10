using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEight : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-191.54f, 3.45f);
    private Vector2 pos2 = new Vector2(-194.51f, 3.45f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
