using System.Linq;
using UnityEngine;

public class Exercioio01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int vidaplayer = 100;

    [SerializeField] bool powerup = false;
    
    void Start()
    {
        //        1. (Verificação de pontos de vida) Um personagem perde pontos
        //de vida após uma batalha.Verifique se ele ainda está vivo.Caso
        //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
        //contrário, "Game Over".


        int vidaplayer = 10;

        if (vidaplayer > 0)
        {
            print("Personagem vivo");
            print("Vida do Player: " + vidaplayer);

        }
        else
        {
            print("Game Over");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
