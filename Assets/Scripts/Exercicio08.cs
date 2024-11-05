using System.Runtime.ConstrainedExecution;
using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio08 : MonoBehaviour
{

    [SerializeField] int horas;
    [SerializeField] float segundos;
    [SerializeField] int dias;

    void Start()
    {
        //        (Contador de horas e dias) Crie um script que em que uma
        //variável inteira hora seja incrementada de uma unidade a cada 10
        //segundos e volte a ser 0 quando alcançar o valor 24.Quando
        //completar um ciclo, incremente uma variável dias e escreva o
        //número de dias que se passaram no console. (Coloque o código
        //dentro da função - evento Update).


    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;


        if (segundos >= 10)
        {
            segundos = 0;
            horas++;
            print(horas + " Horas");
        }
        else if (horas >= 24)
        {
            horas = 0;
            segundos = 0;
            dias++;

            print(dias + " Dias");
        }


    }
}
