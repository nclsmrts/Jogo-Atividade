using UnityEngine;

public class exerciciorepeticao02 : MonoBehaviour
{
    //        (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

    [SerializeField] int dano = 1;
    [SerializeField] int nataque = 0;
    void Start()
    {

    }
    void Update()
    {
        while (nataque < 5)
        {
            nataque++;
            dano *= 2;
            print(dano + " de dano");
        }
    }



}