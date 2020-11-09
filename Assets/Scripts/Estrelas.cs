using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrelas : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AumentarPontuacao();

            FindObjectOfType<AudioManager>().coletandoEstrela.Play();

            Destroy(this.gameObject);
        }
    }
}
