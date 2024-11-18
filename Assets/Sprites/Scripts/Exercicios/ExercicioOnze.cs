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
                Debug.Log("NPC: Olá, aventureiro! Bem-vindo à nossa vila.");
                break;

            case PlayerState.EmProgresso:
                Debug.Log("NPC: Vejo que você está progredindo bem. Continue assim!");
                break;

            case PlayerState.Concluido:
                Debug.Log("NPC: Parabéns por concluir sua jornada! Você é um verdadeiro herói.");
                break;

            default:
                Debug.Log("NPC: Não sei o que dizer...");
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




