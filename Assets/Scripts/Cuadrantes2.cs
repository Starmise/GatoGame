using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuadrantes2 : MonoBehaviour
{
    public GameObject[] Circ = new GameObject[9];
    public GameObject[] btnCuadrante = new GameObject[9];

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            int indice = i;
            btnCuadrante[i].GetComponent<Button>().onClick.AddListener(() => ActivarCirculo(indice));
        }

        for (int i = 0; i < 9; i++)
        {
            Circ[i].SetActive(false);
        }
    }

    void ActivarCirculo(int indice)
    {
        Circ[indice].SetActive(true);
    }
}
