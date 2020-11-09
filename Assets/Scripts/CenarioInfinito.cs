using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioInfinito : MonoBehaviour
{
    public float velocidadeDoScroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cenarioOffset = new Vector2(Time.time * velocidadeDoScroll, 0);

        GetComponent<Renderer>().material.mainTextureOffset = cenarioOffset;
    }
}
