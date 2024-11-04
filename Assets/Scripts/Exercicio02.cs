using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerup = false;
    void Start()
    {
        //        2. (Detecção de power - up) Ao coletar um power-up, o
        //        personagem aumenta sua velocidade.Se o jogador encontrar um
        //power - up, exiba "Power-up Coletado".Caso contrário, exiba
        //"Nenhum power-up encontrado".


        if (powerup == true)
        {
            print("Power-up Coletado");

        }
        else
        {
            print("Nenhum Power-Up encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
