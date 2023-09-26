using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HolaMundo : MonoBehaviour
{
    [SerializeField] private TMP_Text TMPLabel;
    private Name nombre;

    private void Awake()
    {
        nombre = GetComponent<Name>();
    }

    public void Saludar(){
        Debug.Log("Hola" + nombre.GetName());
        TMPLabel.text = nombre.GetName();
    }

    public void LimpiarTexto(){
        TMPLabel.text = "...";
    }
}

