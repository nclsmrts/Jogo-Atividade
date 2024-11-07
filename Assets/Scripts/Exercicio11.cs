using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] string[] ndialogos = { "Você comprou uma espada", "Você comprou uma Poção", "Você comprou um Mapa", "Você já obteve essa espada", "Você já obteve essa Poção", "Você já obteve esse Mapa" };
    [SerializeField] int dialogos = 0;
    [SerializeField] bool item;
    void Start()
    {
        //        (Diálogos)Implemente um sistema de diálogos onde o jogador
        //pode interagir com um NPC(personagem não jogável), e o NPC
        //responde com diferentes frases dependendo do estado do jogo.
        //Use switch case para definir as respostas baseadas no estado do
        //jogador.

        print("O que deseja comprar 1 - Espada  2 - Pocão  3 - Mapa");


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            dialogos++;
            switch (dialogos)
            {
                case 1:
                    if (dialogos == 1 && item)
                    {
                        print(ndialogos[3]);
                        dialogos = 0;
                    }
                    else if (dialogos == 1 && !item)
                    {
                        print(ndialogos[0]);
                        dialogos = 0;
                    }
                    break;
            }
            dialogos = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dialogos++;
            switch (dialogos)
            {
                case 1:
                    if (dialogos == 1 && item)
                    {
                        print(ndialogos[4]);
                        dialogos = 0;
                    }
                    else if (dialogos == 1 && !item)
                    {
                        print(ndialogos[1]);
                        dialogos = 0;                     
                    }

                    break;
            }
            dialogos = 0;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dialogos++;
            switch (dialogos)
            {
                case 1:
                    if (dialogos == 1 && item)
                    {
                        print(ndialogos[5]);
                        dialogos = 0;
                    }
                    else if (dialogos == 1 && !item)
                    {
                        print(ndialogos[2]);
                        dialogos = 0;
                    }
                    break;
            }
            dialogos = 0;
        }




    }
}
