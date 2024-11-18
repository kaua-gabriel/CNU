using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioSeis : MonoBehaviour
{
    [SerializeField] bool mago;
    [SerializeField] bool guerreiro;

    void Start()
    {
        Debug.Log("Escolha seu personagem: Guerreiro ou Mago");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            guerreiro = true;
            mago = false;
            Debug.Log("Guerreiro escolhido");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            mago = true;
            guerreiro = false;
            Debug.Log("Mago escolhido");
        }
        else if (!mago && !guerreiro)
        {
            Debug.Log("Escolha inválida. Pressione 'G' para Guerreiro ou 'M' para Mago.");
        }
    }
}
