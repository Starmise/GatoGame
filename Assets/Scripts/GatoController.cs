using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GatoController : MonoBehaviour
{
    //public GameObject Cruz1, Cruz2, Cruz3, Cruz4, Cruz5, Cruz6, Cruz7, Cruz8, Cruz9;
    //public GameObject Circ1, Circ2, Circ3, Circ4, Circ5, Circ6, Circ7, Circ8, Circ9;
    public GameObject[] Cruz = new GameObject[9];
    public GameObject[] Circ = new GameObject[9];
    public GameObject[] btnCuadrante = new GameObject[9];
    public TextMeshProUGUI txt_turno;

    private bool win = false;
    private int turno = 1;
    int numeroturnos;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Cruz[i].SetActive(false);
            Circ[i].SetActive(false);
            int index = i;

            btnCuadrante[i].GetComponent<Button>().onClick.AddListener(() => ActivarCuadrante(index));
        }

        ActualizarTurno();
    }

    void ActualizarTurno()
    {
        txt_turno.text = "Turno: " + turno;
    }

    void ActivarCuadrante(int indice)
    {
        if (win || Cruz[indice].activeSelf || Circ[indice].activeSelf)
        {
            return;
        }

        if (turno == 1)
        {
            Cruz[indice].SetActive(true);
            if (Victoria(Cruz))
            {
                PlayerPrefs.SetInt("Ganador", 1);
                win = true;
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                turno = 2;
                ActualizarTurno();
            }
            numeroturnos++;
        }
        else
        {
            Circ[indice].SetActive(true);
            if (Victoria(Circ))
            {
                PlayerPrefs.SetInt("Ganador", 2);
                win = true;
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                turno = 1;
                ActualizarTurno();
            }
            numeroturnos++;
        }

        if (!win && numeroturnos>8)
        {
            PlayerPrefs.SetInt("Ganador", 3);
            win = true;
            Debug.Log("Empate");
            SceneManager.LoadScene("GameOver");
        }
    }

    bool Victoria(GameObject[] jugador)
    {
        if (
            (jugador[0].activeSelf && jugador[1].activeSelf && jugador[2].activeSelf) ||
            (jugador[3].activeSelf && jugador[4].activeSelf && jugador[5].activeSelf) ||
            (jugador[6].activeSelf && jugador[7].activeSelf && jugador[8].activeSelf) ||
            (jugador[0].activeSelf && jugador[3].activeSelf && jugador[6].activeSelf) ||
            (jugador[1].activeSelf && jugador[4].activeSelf && jugador[7].activeSelf) ||
            (jugador[2].activeSelf && jugador[5].activeSelf && jugador[8].activeSelf) ||
            (jugador[0].activeSelf && jugador[4].activeSelf && jugador[8].activeSelf) ||
            (jugador[2].activeSelf && jugador[4].activeSelf && jugador[6].activeSelf)
           )
        {
            return true;
        }
        return false;
    }

    bool CuadrantesLlenos()
    {
        foreach (GameObject cuadrante in Cruz)
        {
            if (!cuadrante.activeSelf)
                return true;
        }
        foreach (GameObject cuadrante in Circ)
        {
            if (!cuadrante.activeSelf)
                return true;
        }
        return false;
    }

    /*
    void TurnoCruces()
    {
        if (turno == 1)
        {
            for (int i = 0; i < 9; i++)
            {
                int indice = i;
                btnCuadrante[i].GetComponent<Button>().onClick.AddListener(() => ActivarCruz(indice));
            }
        }

        txt_turno.text = turno.ToString();
    }

    void TurnoCirculos()
    {
        if (turno == 2)
        {
            for (int i = 0; i < 9; i++)
            {
                int indice = i;
                btnCuadrante[i].GetComponent<Button>().onClick.AddListener(() => ActivarCirculo(indice));
            }
        }

        txt_turno.text = turno.ToString();
    }

    void ActivarCruz(int indice)
    {
        Cruz[indice].SetActive(true);
        turno = 2;
        TurnoCirculos();
    }

    void ActivarCirculo(int indice)
    {
        Circ[indice].SetActive(true);
        turno = 1;
        TurnoCruces();
    }*/
}
