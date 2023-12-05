using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    [SerializeField] private int indiceEscenaJuego;

    public void IniciarJuego()
    {
        SceneManager.LoadScene(indiceEscenaJuego);
    }

    public void CerrarAplicacion()
    {
        Application.Quit();
    }

}
