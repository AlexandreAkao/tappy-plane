using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComOtempo : MonoBehaviour
{
    public float tempoParaDestruir;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoParaDestruir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
