using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioDois : MonoBehaviour
{
    public float Velocidade { get; set; }

    void Start()
    {
        Velocidade = 5.0f;
        ColetarPowerUp(true); // false 
    }

    void Update()
    {

    }

    public void ColetarPowerUp(bool encontrouPowerUp)
    {
        if (encontrouPowerUp)
        {
            Velocidade += 2.0f;
            Debug.Log("Power-up Coletado");
        }
        else
        {
            Debug.Log("Nenhum power-up encontrado");
        }
    }
}
