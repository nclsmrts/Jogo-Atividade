using UnityEngine;

public class exerciciorepeticao04 : MonoBehaviour
{

    //    4. (Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int combos;
    [SerializeField] int pontos;

    void Start()
    {
        //while (combos < 7)
        //{
        //    pontos += 10;
        //    combos++;
        //    if (combos == 7)
        //    {
        //        print(pontos);
        //        break;
        //    }
        //}

    }

    void Update()
    {
        while (combos < 7)
        {
            pontos += 10;
            combos++;

            if (combos == 7)
            {
                print("Quantidade de combos foi: " + combos);
                print(pontos+ " Pontos");
                break;
            }
        }
    }
}
