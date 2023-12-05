using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ValidarRespuestas : MonoBehaviour
{

    [SerializeField] private string respuesta;
    public ListaAdivinanzas preguntas;


    public void ValidarRespuesta()
    {
        Adivinanza adivinanzaActual = preguntas.GetCurrentRiddle();
        Debug.Log("[Validar] respuesta: " + respuesta);
        Debug.Log("[Validar] answer: " + adivinanzaActual.answer);

        // if (adivinanzaActual != null && respuesta == adivinanzaActual.answer)
        // {
        //     preguntas.CambiarTexto("**Correcto**\n|Respuesta: " + respuesta + "|");
        // }
    }


}

