using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioQuatro : MonoBehaviour
{
    [SerializeField] bool pocaoVida; // Corrigido para SerializeField
    string resultado;

    // M�todo Start � chamado uma vez ao iniciar a cena
    void Start()
    {
        if (pocaoVida)
        {
            print("Usando po��o de vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }

    // M�todo Update � chamado a cada frame, mas n�o � necess�rio nesse caso
    void Update()
    {
        // Se precisar realizar alguma a��o a cada frame, pode adicionar aqui
    }
}
