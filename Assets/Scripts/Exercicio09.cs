using System;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int pontosA;
    [SerializeField] int pontosB;

    System.Random pontos = new System.Random();

    void Start()
    {
        //        (Placar final) Crie um script que l� o placar de uma partida entre
        //time A e time B. Depois, escreva no console qual dos tr�s
        //resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
        //ou empate.Se o empate teve mais de 3 pontos para cada lado,
        //escreva que foi �um empate emocionante�.

        pontosA = pontos.Next(0,5);
        pontosB = pontos.Next(0,5);

        if (pontosA > pontosB)
        {
            print("Vit�ria time A");
        }
        else if (pontosB >= 3 && pontosA >= 3)
        {
          print("Um empate emocionante!!");
        }
        else if (pontosB == pontosA)
        {
            print("Empate!");
        }
        else
        {
            print("Vit�ria do time B");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
