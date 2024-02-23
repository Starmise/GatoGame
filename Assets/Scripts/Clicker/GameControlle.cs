using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControlle : MonoBehaviour
{
    [SerializeField] private TMP_Text txt_score;
    [SerializeField] private int addScore = 25;
    private int score;

    void Start()
    {
        score = 0;
    }

    public void Puchame()
    {
        score += addScore;
        txt_score.text = score.ToString();
    }
}

/*
 * Awake - Antes de iniciar
 * Start - Inicio
 * OnEnable - Activo
 * OnDisable - Desactivado
 * Update - Cada frame
 * Lastupdate - Después de todos los frames
 * FixedUpdate -Físicas
 */