using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExercicioCinco : MonoBehaviour
{
    public class Missao
    {
        [SerializeField] private int Pontos = 0; // Corrigido para SerializeField e uso de variáveis privadas

        public Missao()
        {
            Pontos = 0;
        }

        public void CompletarMissao(int pontosGanhos)
        {
            Pontos += pontosGanhos;
            VerificarPontos();
        }

        private void VerificarPontos()
        {
            // Usando Debug.Log para imprimir no console do Unity
            if (Pontos >= 50)
            {
                Debug.Log("Missão bem-sucedida");
            }
            else
            {
                Debug.Log("Missão incompleta");
            }
        }
    }

    void Start()
    {
        Missao missao = new Missao();

        missao.CompletarMissao(60); // Testando com 60 pontos

        missao.CompletarMissao(30); // Testando com 30 pontos
    }
}
