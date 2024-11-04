using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    [SerializeField] int personagem;
   
    void Start()
    {
        //        (Escolha de personagem) O jogador pode escolher entre o
        //personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
        //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
        //Mago.



        switch (personagem)
        {

            case 1:
                print("Guerreiro escolhido");
                break;

            case 2:
                print("Mago escolhido");
                break;


            default:
                print("Personagem não encontrado");
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
