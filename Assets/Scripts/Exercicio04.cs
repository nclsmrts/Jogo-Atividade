using UnityEngine;
using static UnityEditor.Progress;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaovida;

    void Start()
    {
        //        (Verificar item de inventário) Um jogador possui itens limitados
        //no inventário.Verifique se o jogador possui uma "Poção de Vida".
        //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
        //indisponível".

        if (pocaovida == true)
        {
            print("Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }

    }

    void Update()
    {

    }

}
