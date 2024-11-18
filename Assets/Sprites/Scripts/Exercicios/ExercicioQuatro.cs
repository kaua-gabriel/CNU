using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioQuatro : MonoBehaviour
{
    [SerializeField] bool pocaoVida; // Corrigido para SerializeField
    string resultado;

    // Método Start é chamado uma vez ao iniciar a cena
    void Start()
    {
        if (pocaoVida)
        {
            print("Usando poção de vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Método Update é chamado a cada frame, mas não é necessário nesse caso
    void Update()
    {
        // Se precisar realizar alguma ação a cada frame, pode adicionar aqui
    }
}
