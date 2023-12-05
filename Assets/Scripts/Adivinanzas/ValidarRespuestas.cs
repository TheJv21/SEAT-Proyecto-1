using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ValidarRespuestas : MonoBehaviour
{

    [SerializeField] private string respuesta;
    [SerializeField] private ListaAdivinanzas preguntas;
    private static int punteo;
    private bool flag = false;


    public void ValidarRespuesta()
    {
        Adivinanza adivinanzaActual = preguntas.GetCurrentRiddle();
        // Debug.Log("respuesta: "+respuesta);
        // Debug.Log("answer: "+adivinanzaActual.answer);

        if (adivinanzaActual != null && respuesta == adivinanzaActual.answer)
        {
            preguntas.CambiarTexto("**Correcto**\n|Respuesta: " + respuesta + "|");
            Puntuacion();

        }
        else
        {
            preguntas.CambiarTexto("**Incorrecto**\n|Intentalo de nuevo");
        }

    }

    public void FueraFoco()
    {
        preguntas.MostrarAdivinanza();
    }

    public void Puntuacion()
    {
        if (flag == false)
        {
            punteo = punteo + 50;
            flag = true;
            preguntas.CambiarPuntos("Puntos: "+punteo);
        }
    }


}

