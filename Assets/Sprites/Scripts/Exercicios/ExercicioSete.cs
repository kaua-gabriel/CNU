using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    void Start()
    {
        int numeroDeFaces = 6; 

        int resultado = RolarDado(numeroDeFaces);

        Debug.Log("Resultado da rolagem: " + resultado);
    }

    int RolarDado(int faces)
    {
        return Random.Range(1, faces + 1);
    }
}