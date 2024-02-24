using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatoController : MonoBehaviour
{
    //public GameObject Cruz1, Cruz2, Cruz3, Cruz4, Cruz5, Cruz6, Cruz7, Cruz8, Cruz9;
    //public GameObject Circ1, Circ2, Circ3, Circ4, Circ5, Circ6, Circ7, Circ8, Circ9;
    public GameObject[] Cruz = new GameObject[9];
    public GameObject[] Circ = new GameObject[9];
    public GameObject[] btnCuadrante = new GameObject[9];

    private bool win = false;
    private int turno = 1;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Cruz[i].SetActive(false);
            Circ[i].SetActive(false);
        }

        TurnoCruces();
    }

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
    }
}
