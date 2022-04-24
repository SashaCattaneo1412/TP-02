using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text miTexto;

    void Start()
    {
        
        if ( edadUsuario >= 18)
        {
            miTexto.text = "Es mayor de Edad";
            Debug.Log("Es mayor de Edad");
        }
        else
        {
            miTexto.text = "No es mayor de Edad";
            Debug.Log("No es mayor de Edad");
        }

    }
}
