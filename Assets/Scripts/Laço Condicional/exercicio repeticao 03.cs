using UnityEngine;

public class exerciciorepeticao03 : MonoBehaviour
{

    //    (C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    //cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.

    [SerializeField] int fases = 1;
    [SerializeField] int moedas = 0;

    void Start()
    {
        while (fases < 10)
        {
            moedas += 3;
            fases++;
            print("Voc� coletou: " + moedas);
        }

        if (fases == 10)
        {
            print("Voc� coletou no total: " + moedas);
        }
    }

    void Update()
    {
        //while (fases < 10)
        //{
        //    moedas += 3;
        //    fases++;
        //    print("Voc� coletou: " + moedas);
        //}

        //if (fases == 10)
        //{
        //    print("Voc� coletou no total: " + moedas);
        //}

    }
}
