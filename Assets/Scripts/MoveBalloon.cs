using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    public float speed;


    private void FixedUpdate ()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime);
	}
}
