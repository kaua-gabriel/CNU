using UnityEngine;

public class ExercicioOnze : MonoBehaviour
{
    public enum PlayerState
    {
        Iniciante,
        EmProgresso,
        Concluido
    }

    public PlayerState estadoDoJogador;

    public void InteragirComNPC()
    {
        switch (estadoDoJogador)
        {
            case PlayerState.Iniciante:
                Debug.Log("NPC: Ol�, aventureiro! Bem-vindo � nossa vila.");
                break;

            case PlayerState.EmProgresso:
                Debug.Log("NPC: Vejo que voc� est� progredindo bem. Continue assim!");
                break;

            case PlayerState.Concluido:
                Debug.Log("NPC: Parab�ns por concluir sua jornada! Voc� � um verdadeiro her�i.");
                break;

            default:
                Debug.Log("NPC: N�o sei o que dizer...");
                break;
        }
    }

    void Start()
    {
        estadoDoJogador = PlayerState.Iniciante;
        InteragirComNPC();

        estadoDoJogador = PlayerState.EmProgresso;
        InteragirComNPC();

        estadoDoJogador = PlayerState.Concluido;
        InteragirComNPC();
    }
}




