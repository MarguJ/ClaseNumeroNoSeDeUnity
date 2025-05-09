using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SUMAUI : MonoBehaviour
{
    public TextMeshProUGUI resultado;
    public TMP_InputField INumero1;
    public TMP_InputField INumero2;
    int num1;
    int num2;

    // Start is called before the first frame update
    void Start()
    {
        resultado.text = "";
    }

    public void SumarYMostrar()
    {
        num1 = int.Parse(INumero1.text);
        num2 = int.Parse(INumero2.text);
        resultado.text = (num1 + num2).ToString();
    }
 }
