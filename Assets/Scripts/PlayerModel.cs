using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    //Atributos
    private float fuerza;
    private float velocidad;
    private float posX;
    private float posY;
    private int direction;
    private string nombre;
    private SpriteRenderer myImg;

    public PlayerModel()
    {
        direction = 1;
        posX = 0;
        posY = 0;
    }

    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
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

    public int Direccion
    {
        get { return direction; }
        set { direction = value; }
    }
}
