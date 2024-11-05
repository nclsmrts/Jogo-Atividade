using UnityEngine;
using static UnityEditor.Progress;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] int itens;

    void Start()
    {
        //        10. (Itens do invent�rio) Crie um script onde o jogador pode coletar
        //diferentes tipos de itens(como moedas, po��es, ou power-ups)
        //que t�m efeitos diferentes dependendo do tipo coletado. Use um
        //switch case para determinar o efeito de cada tipo de item.

        switch (itens)
        {
            case 1:
                print("Voc� coletou uma moeda");
                print("Agora Voc� est� mais rico!!");
                break;

            case 2:
                print("Voc� consumiu uma po��o");
                print("Recuperou vida!");
                break;

            case 3:
                print("Voc� obteve um Power-Up");
                print("Est� mais forte!!");
                break;

            default:
                print("N�o coletou item");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
