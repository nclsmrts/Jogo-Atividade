using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int dialogos = 0;
    void Start()
    {
        //        (Di�logos)Implemente um sistema de di�logos onde o jogador
        //pode interagir com um NPC(personagem n�o jog�vel), e o NPC
        //responde com diferentes frases dependendo do estado do jogo.
        //Use switch case para definir as respostas baseadas no estado do
        //jogador.

        print("O que deseja comprar\n 1 - Espada \n 2 - Poc�o \n 3 - Mapa");

        //switch (dialogos)
        //{
        //    case 1:
        //        print("Voc� comprou uma espada");
        //        break;

        //    case 2:
        //        print("Voc� comprou uma Po��o");
        //        break;

        //    case 3:
        //        print("Voc� comprou um Mapa");
        //        break;

        //    default:
        //        print("N�o existe essa op��o");
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
            print("Voc� comprou uma espada");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("Voc� comprou uma Po��o");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("Voc� comprou um Mapa");
        }
        else
        {
            //print("N�o existe essa op��o");
        }
    }
}
