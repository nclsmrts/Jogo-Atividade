using UnityEngine;

public class exerciciorepetição05 : MonoBehaviour
{

    //    (Aumento de nível de dificuldade) A cada fase completada, a
    //dificuldade aumenta em 5 pontos.Exiba a dificuldade após cada
    //fase, em um total de 6 fases.

    [SerializeField] int dificuldade;
    [SerializeField] int fases = 1;


    void Start()
    {
        while (fases < 7)
        {
            fases++;
            dificuldade += 5;
            print("Dificuldade: " + dificuldade);
        }
    }

    void Update()
    {

    }
}
