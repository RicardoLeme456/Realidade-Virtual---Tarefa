using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    int numero1, numero2, resultadoSub;

    // Start is called before the first frame update
    void Start()
    {
        numero1 = 10;
        numero2 = 30;
        Soma();
        Multiplicação(numero1, numero2);
        resultadoSub = sub(numero1, numero2);
        Debug.Log(resultadoSub);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Soma()
    {
        int resultado;
        resultado = numero1 + numero2;
        Debug.Log(resultado);
    }

    void Multiplicação(int valorA, int valorB)
    {
        int resultado;
        resultado = valorA * valorB;
        Debug.Log(resultado);
    }
    int sub(int valorA, int valorB)
    {
        int resultado = valorB - valorA;
        return resultado;
    }
}
