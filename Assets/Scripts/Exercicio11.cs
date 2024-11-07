using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] string[] ndialogos = { "Voc� comprou uma espada", "Voc� comprou uma Po��o", "Voc� comprou um Mapa", "Voc� j� obteve essa espada", "Voc� j� obteve essa Po��o", "Voc� j� obteve esse Mapa" };
    [SerializeField] int dialogos = 0;
    [SerializeField] bool item;
    void Start()
    {
        //        (Di�logos)Implemente um sistema de di�logos onde o jogador
        //pode interagir com um NPC(personagem n�o jog�vel), e o NPC
        //responde com diferentes frases dependendo do estado do jogo.
        //Use switch case para definir as respostas baseadas no estado do
        //jogador.

        print("O que deseja comprar 1 - Espada  2 - Poc�o  3 - Mapa");


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
