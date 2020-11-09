using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    public float alturaDoPulo;

    public Rigidbody2D oRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oRigidbody2D.velocity = Vector2.zero;
            oRigidbody2D.AddForce(Vector2.up * alturaDoPulo);
        }
    }
}
