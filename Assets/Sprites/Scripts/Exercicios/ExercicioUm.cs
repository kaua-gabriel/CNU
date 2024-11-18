using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioUm : MonoBehaviour
{
    [SerializeField] int pontosDeVida = 10;

    void Start()
    {
        if (pontosDeVida > 0)
        {
            Debug.Log("Personagem Vivo");
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    void Update()
    {

    }
}