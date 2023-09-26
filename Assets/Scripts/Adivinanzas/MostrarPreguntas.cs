using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;



[System.Serializable]
public class Adivinanza
{
    public string question;
    public string answer;
}

public class MostrarPreguntas : MonoBehaviour

{
    private static List<Adivinanza> adivinanza;
    private static int currentRiddleIndex;
    private static Adivinanza adivinanzaActual;
    [SerializeField] private TMP_Text TMPLabel;
    [SerializeField] private string respuesta; 

    private void Start()
    {
         // Configura las adivinanzas en la lista
        adivinanza = new List<Adivinanza>
        {
            new Adivinanza
            {
                question = "Soy el hogar de insectos, y me alimento de la luz.\n¿Qué soy?",
                answer = "Hojas",
            },
            new Adivinanza
            {
                question = "Soy dura y pesada, pero me puedo romper.¿Qué soy?",
                answer = "Rocas",
            },
            new Adivinanza
            {
                question = "Tengo agujas pero no sé coser,Tengo números pero no sé leer,\nLas horas te doy,¿Sabes quién soy?",
                answer = "Reloj",
            },
             new Adivinanza
            {
                question = "¿Qué es lo que cuanto más grande es menos se ve?",
                answer = "Oscuridad",
            },
             new Adivinanza
            {
                question = "Existo cuando me guardan,\nMuero cuando me sacan.",
                answer = "Secreto",
            },

        };
        
        // Luego, puedes mezclar las adivinanzas para que se muestren de manera aleatoria
        Aleatorio();
        MostrarAdivinanza();
    }

        public void Aleatorio()
    {
        // Mezcla las adivinanzas en la lista
        for (int i = 0; i < adivinanza.Count; i++)
        {
            int randomIndex = Random.Range(i, adivinanza.Count);
            Adivinanza temp = adivinanza[i];
            adivinanza[i] = adivinanza[randomIndex];
            adivinanza[randomIndex] = temp;
        }
    }

        public void MostrarAdivinanza()
    {
        // Obten la adivinanza actual del script MostrarPregunta
        Adivinanza adivinanzaActual = GetCurrentRiddle();

        if (adivinanzaActual != null)
        {
            // Mostrar la pregunta de la adivinanza en el componente de texto
            TMPLabel.text = adivinanzaActual.question;
        }
        else
        {
            // Manejar el caso en el que no haya más adivinanzas disponibles
            TMPLabel.text = "No hay más adivinanzas.";
        }
    }


    public void NextRiddle()
    {
        currentRiddleIndex=currentRiddleIndex+1;
    }


        public void CambiarTexto(string texto)
    {
        TMPLabel.text = texto;
    }


        public void ValidarRespuesta()
    {
        
        
        Adivinanza adivinanzaActual = GetCurrentRiddle();
        Debug.Log(currentRiddleIndex);
        Debug.Log("respuesta: "+respuesta);
        Debug.Log("answer: "+adivinanzaActual.answer);

        if (adivinanzaActual != null && respuesta == adivinanzaActual.answer)
        {
            CambiarTexto("**Correcto**\n| Respuesta: "+respuesta+" |");
        }

         if (adivinanzaActual != null && respuesta != adivinanzaActual.answer)
        {
            CambiarTexto("**Incorrecto**\n| Intentalo de nuevo |");
        }
    }




    
    // Cambiar a la siguiente adivinanza
    public void ReRoll(){
        NextRiddle();
        MostrarAdivinanza();
    }


 public Adivinanza GetCurrentRiddle()
    {
        if (currentRiddleIndex < adivinanza.Count)
        {
            return adivinanza[currentRiddleIndex];
        }
        return null;
    }

}