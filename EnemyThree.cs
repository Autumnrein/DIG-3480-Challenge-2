using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThree : MonoBehaviour
{

    private Vector2 pos1 = new Vector2(-11.52f, -1.46f);
    private Vector2 pos2 = new Vector2(-13.57f, -1.46f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
