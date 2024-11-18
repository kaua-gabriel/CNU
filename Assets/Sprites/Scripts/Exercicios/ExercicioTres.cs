using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioTres : MonoBehaviour
{
    [SerializeField] bool playerVivo = true;
    [SerializeField] bool powerUp = false;
    double vidaPlayer = 100;

    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        if (playerVivo && powerUp)
        {
            vidaPlayer = vidaPlayer * 5.0;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }

        switch (estadoVilao)
        {
            case 1:
                print("Vilao atacando");
                print("dano");
                break;

            case 2:
                print("Vilao defende");
                break;

            case 3:
                print("Vilao tomando um coro");
                break;

            default:
                print("Valor não identificado");
                break;
        }
    }

    void Update()
    {
    }
}