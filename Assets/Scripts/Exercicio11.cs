using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int dialogos = 0;
    void Start()
    {
        //        (Diálogos)Implemente um sistema de diálogos onde o jogador
        //pode interagir com um NPC(personagem não jogável), e o NPC
        //responde com diferentes frases dependendo do estado do jogo.
        //Use switch case para definir as respostas baseadas no estado do
        //jogador.

        print("O que deseja comprar\n 1 - Espada \n 2 - Pocão \n 3 - Mapa");

        //switch (dialogos)
        //{
        //    case 1:
        //        print("Você comprou uma espada");
        //        break;

        //    case 2:
        //        print("Você comprou uma Poção");
        //        break;

        //    case 3:
        //        print("Você comprou um Mapa");
        //        break;

        //    default:
        //        print("Não existe essa opção");
        //        break;
        //}

        //if (Input.GetKeyDown(KeyCode.E){

        //}

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("Você comprou uma espada");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("Você comprou uma Poção");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("Você comprou um Mapa");
        }
        else
        {
            //print("Não existe essa opção");
        }
    }
}
