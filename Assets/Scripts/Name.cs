using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
    [SerializeField] private string nombre;

    public string GetName(){
        return nombre;
    }
}
