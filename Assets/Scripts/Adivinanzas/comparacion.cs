using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class comparacion : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string respuesta; 
    // [SerializeField] private GameObject mariposa; 
    // [SerializeField] private GameObject paisaje;
    private MostrarPreguntas preguntas;
    private Adivinanza adivinanzaActual;

    private void Awake()
    {
        preguntas = GetComponent<MostrarPreguntas>();
    }


    public void ValidarRespuesta()
    {
        adivinanzaActual = preguntas.GetCurrentRiddle();
        Debug.Log("respuesta: "+respuesta);
        Debug.Log("answer: "+adivinanzaActual.answer);

        if (adivinanzaActual != null && respuesta == adivinanzaActual.answer)
        {
            preguntas.CambiarTexto("**Correcto**\n|Respuesta: "+respuesta+"|");
        }
    }


    // Cambiar a la siguiente adivinanza
    public void ReRoll(){
        preguntas.NextRiddle();
        adivinanzaActual = preguntas.GetCurrentRiddle();
        preguntas.MostrarAdivinanza();
    }

    
}

