using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio07 : MonoBehaviour
{
    [SerializeField] int insira; 
    [SerializeField] int numerosfaces;

    System.Random nfaces = new System.Random();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //        (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
        //calcular probabilidades e simular a rolagem de dados.Crie um
        //script em que o usu�rio defina o n�mero de faces de um dado
        //(int) e calcule a rolagem de um dado com esse n�mero de faces.
        //Use a fun��o abaixo para o c�lculo: Random.Range(valor_min,
        //valor_max); (Coloque o c�digo dentro da fun��o - evento Start).

        numerosfaces = nfaces.Next(1,insira);

        print(numerosfaces);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
