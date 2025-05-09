using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaludoUIManager : MonoBehaviour
{
    public TextMeshProUGUI saludo;
    public TMP_InputField inputNombre;
    string nombreAIngresar;
    // Start is called before the first frame update
    void Start()
    {
        saludo.text = "";
    }

    public void saludar()
    {
        nombreAIngresar = inputNombre.text;
        saludo.text = "Hola " + nombreAIngresar;
    }
}
