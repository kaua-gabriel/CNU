using UnityEngine;
using static ExercicioOnze;

public class ExercicioOnze : MonoBehaviour
{
    void Start()
    {

        switch (estado)
        {
            case 1:
                print("NPC: Ol�, aventureiro! Bem-vindo � nossa vila.");
                break;

            case 2:
                print("NPC: Vejo que voc� est� progredindo bem. Continue assim!");
                break;

            case 3:
                print("NPC: Parab�ns por concluir sua jornada! Voc� � um verdadeiro her�i.");
                break;

            default:
                print("NPC: N�o sei o que dizer...");
                break;
        }
    }
}




