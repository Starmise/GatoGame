using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI txt_ganador;
    private int jGanador;

    void Start()
    {
        jGanador = PlayerPrefs.GetInt("Ganador");

        txt_ganador.text = "" + jGanador;

        if (jGanador == 3)
        {
            txt_ganador.text = "Empate";
        }
    }

    public void VolverAJugar()
    {
        SceneManager.LoadScene("Gato");
    }

    public void SalirJuego()
    {
        Application.Quit();
    }
}
