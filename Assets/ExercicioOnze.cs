using UnityEngine;
using static ExercicioOnze;

public class ExercicioOnze : MonoBehaviour
{
    void Start()
    {

        switch (estado)
        {
            case 1:
                print("NPC: Olá, aventureiro! Bem-vindo à nossa vila.");
                break;

            case 2:
                print("NPC: Vejo que você está progredindo bem. Continue assim!");
                break;

            case 3:
                print("NPC: Parabéns por concluir sua jornada! Você é um verdadeiro herói.");
                break;

            default:
                print("NPC: Não sei o que dizer...");
                break;
        }
    }
}




