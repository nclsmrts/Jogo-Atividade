using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour


{
    [SerializeField] int pontosplayer;

    System.Random pontos = new System.Random();
    [SerializeField] int pontuacao;

    void Start()
    {
        //        (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
        //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
        //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
        //incompleta".

        pontuacao = pontos.Next(0, 100);

        pontosplayer = pontuacao;


        if (pontosplayer >= 50)
        {
            print("Miss�o bem-sucedida, sua pontua��o: " + pontosplayer);

        }
        else
        {
            print("Miss�o incompleta, sua pontua��o: " + pontosplayer);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
