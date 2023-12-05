using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class comparacion : MonoBehaviour
{
    
    [SerializeField] private string respuesta; 
    [SerializeField] private ListaAdivinanzas preguntas;


    public void ValidarRespuesta()
    {
        Adivinanza adivinanzaActual = preguntas.GetCurrentRiddle();
        Debug.Log("respuesta: "+respuesta);
        Debug.Log("answer: "+adivinanzaActual.answer);

        if (adivinanzaActual != null && respuesta == adivinanzaActual.answer)
        {
            preguntas.CambiarTexto("**Correcto**\n|Respuesta: "+respuesta+"|");
        }
    }



    
}

