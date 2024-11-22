using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    [SerializeField] string texto = "JOGOS digitais";
    [SerializeField] int contadorConsoantes;
    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(letra)))
            {
                contadorConsoantes++;
            }
        }

        print("O número de consoantes é: " + contadorConsoantes);
    }

    void Update()
    {
        
    }
}
