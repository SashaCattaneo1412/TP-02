using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        cartelitoMsj.SetActive(false);
        contraseñaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContraseña()
    {
        contraseñaUsuario = ingresoUsuario.text;
        if(contraseñaUsuario == contraseñaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text="Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");

        }
    }
}
