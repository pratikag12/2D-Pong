using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {
    public float speed = 30;
    public string axes = "Vertical";

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axes);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v)*speed;
    }
}
