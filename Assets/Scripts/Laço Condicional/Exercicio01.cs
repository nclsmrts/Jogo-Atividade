using UnityEngine;

public class Exercicio01 : MonoBehaviour
{

    //    (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "In�cio da partida!" ao final.



    void Start()
    {
        for (int i = 5; i > 0 ; i--)
        {
            print(i);

        }
        print("In�cio da partida!");
    }


    void Update()
    {

    }
}
