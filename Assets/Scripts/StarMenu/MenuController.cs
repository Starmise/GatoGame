using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string nextLevel;

    public void LoadScene()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void LoadGato()
    {
        SceneManager.LoadScene("Gato");
    }
}
