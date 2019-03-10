using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    
    private Vector2 pos1 = new Vector2(5.48f, 2.34f);
    private Vector2 pos2 = new Vector2(4.44f, 2.34f);
    public float speed = 1.0f;

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
