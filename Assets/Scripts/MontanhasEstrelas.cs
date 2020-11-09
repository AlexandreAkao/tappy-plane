using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontanhasEstrelas : MonoBehaviour
{
    public GameObject[] montanhas;
    public float tempoEntreAsMontanhas;
    public float tempoAtualMontanhas;

    public GameObject[] estrelas;
    public float tempoEntreAsEstrelas;
    public float tempoAtualEstrelas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualMontanhas -= Time.deltaTime;

        if (tempoAtualMontanhas <= 0)
        {
            int montanhaAleatoria = Random.Range(0, montanhas.Length);

            Instantiate(montanhas[montanhaAleatoria], transform.position, transform.rotation);

            tempoAtualMontanhas = tempoEntreAsMontanhas;
        }

        tempoAtualEstrelas -= Time.deltaTime;

        if (tempoAtualEstrelas <= 0)
        {
            int estrelaAleatoria = Random.Range(0, estrelas.Length);

            Instantiate(estrelas[estrelaAleatoria], transform.position, transform.rotation);

            tempoAtualEstrelas = tempoEntreAsEstrelas;
        }
    }
}
