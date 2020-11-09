using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacao;
    public Text pontuacaoTexto;
    public bool jogoPausado;

    public GameObject pausePainel;
    public GameObject gameOverPainel;
    public Text pontuacaoFinalTexto;
    public Text highScoreTexto;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        pontuacao = 0;
        pontuacaoTexto.text = pontuacao.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausarJogo();
        }
    }

    public void AumentarPontuacao()
    {
        pontuacao += 1;
        pontuacaoTexto.text = pontuacao.ToString();
    }

    public void PausarJogo()
    {
        if (jogoPausado)
        {
            pausePainel.SetActive(false);

            Time.timeScale = 1f;

            jogoPausado = false;
        }
        else
        {
            pausePainel.SetActive(true);

            Time.timeScale = 0f;

            jogoPausado = true;
        }
    }

    public void CarregarTelaDeCreditos()
    {
        SceneManager.LoadScene(1);
    }

    public void SairDoJogo()
    {
        Debug.Log("Saindo do Jogo!");
        Application.Quit();
    }

    public void MostrarTelaDeGameOver()
    {
        FindObjectOfType<AudioManager>().musicaDoJogo.Stop();
        FindObjectOfType<AudioManager>().musicaGameOver.Play();

        Debug.Log("Game Over");
        Time.timeScale = 0f;

        gameOverPainel.SetActive(true);
        pontuacaoFinalTexto.text = "PONTUAÇÃO: " + pontuacao;
        highScoreTexto.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");

        if (pontuacao > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", pontuacao);
        }
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(0);
    }
}
