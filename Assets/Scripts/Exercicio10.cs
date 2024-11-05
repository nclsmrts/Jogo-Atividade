using UnityEngine;
using static UnityEditor.Progress;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] int itens;

    void Start()
    {
        //        10. (Itens do inventário) Crie um script onde o jogador pode coletar
        //diferentes tipos de itens(como moedas, poções, ou power-ups)
        //que têm efeitos diferentes dependendo do tipo coletado. Use um
        //switch case para determinar o efeito de cada tipo de item.

        switch (itens)
        {
            case 1:
                print("Você coletou uma moeda");
                print("Agora Você está mais rico!!");
                break;

            case 2:
                print("Você consumiu uma poção");
                print("Recuperou vida!");
                break;

            case 3:
                print("Você obteve um Power-Up");
                print("Está mais forte!!");
                break;

            default:
                print("Não coletou item");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
