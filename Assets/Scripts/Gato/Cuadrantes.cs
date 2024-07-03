using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuadrantes : MonoBehaviour
{
    //public GameObject Cruz1, Cruz2, Cruz3, Cruz4, Cruz5, Cruz6, Cruz7, Cruz8, Cruz9;
    //public GameObject Circ1, Circ2, Circ3, Circ4, Circ5, Circ6, Circ7, Circ8, Circ9;
    public GameObject[] Cruz = new GameObject[9];
    public GameObject[] btnCuadrante = new GameObject[9];

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            int indice = i;
            btnCuadrante[i].GetComponent<Button>().onClick.AddListener(() => ActivarCruz(indice));
        }

        for (int i = 0; i < 9; i++)
        {
            Cruz[i].SetActive(false);
        }
    }

    void ActivarCruz(int indice)
    {
        Cruz[indice].SetActive(true);
    }
}
