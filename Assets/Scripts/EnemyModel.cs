using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    private float fuerza;
    private float velocidad;
    private float posX;
    private float posY;
    private float vidas;
    private string nombre;

    public EnemyModel()
    {
        vidas = 3;
        fuerza = 5;
        velocidad = 3;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Fuerza
    {
        get { return fuerza; }
        set { fuerza = value; }
    }

    public float Velocidad
    {
        get { return velocidad; }
        set { velocidad = value; }
    }

    public float Vidas
    {
        get { return vidas; }
        set { vidas = value; }
    }
}
