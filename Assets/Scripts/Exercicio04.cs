using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaovida;

    void Start()
    {
        //        (Verificar item de invent�rio) Um jogador possui itens limitados
        //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
        //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
        //indispon�vel".

        if (pocaovida == true)
        {
            print("Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }

    }

    void Update()
    {

    }

}
