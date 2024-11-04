using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour


{
    [SerializeField] int pontosplayer;

    System.Random pontos = new System.Random();
    [SerializeField] int pontuacao;

    void Start()
    {
        //        (Pontuação de missão) Após completar uma missão, o jogador
        //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
        //exiba "Missão bem-sucedida"; caso contrário, "Missão
        //incompleta".

        pontuacao = pontos.Next(0, 100);

        pontosplayer = pontuacao;


        if (pontosplayer >= 50)
        {
            print("Missão bem-sucedida, sua pontuação: " + pontosplayer);

        }
        else
        {
            print("Missão incompleta, sua pontuação: " + pontosplayer);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
