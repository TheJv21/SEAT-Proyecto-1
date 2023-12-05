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

public class ListaAdivinanzas : MonoBehaviour

{
    private static List<Adivinanza> adivinanza;
    private static int currentRiddleIndex;
    [SerializeField] private List<Adivinanza> adivinanzaInspector = new List<Adivinanza>();
    [SerializeField] private TMP_Text TMPLabel;


    private void Start()
    {
        adivinanza = new List<Adivinanza>(adivinanzaInspector);
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
            //TMPLabel.text = adivinanzaActual.question;
            CambiarTexto(""+adivinanzaActual.question);
        }
        else
        {
            // Manejar el caso en el que no haya más adivinanzas disponibles
            //TMPLabel.text = "No hay más adivinanzas.";
            CambiarTexto("No hay más adivinanzas.");
        }
    }

    //Funcion para cambiar el texto en pantalla
    public void CambiarTexto(string texto)
    {
        TMPLabel.text = texto;
    }

    public Adivinanza GetCurrentRiddle()
    {
        if (currentRiddleIndex < adivinanza.Count)
        {
            return adivinanza[currentRiddleIndex];
        }
        return null;
    }

    public void NextRiddle()
    {
        currentRiddleIndex = currentRiddleIndex + 1;
    }

    public void ReRoll()
    {
        NextRiddle();
        MostrarAdivinanza();
    }

}