using UnityEngine;
using UnityEngine.Video;

public class Exercicio03 : MonoBehaviour
{
    [SerializeField] int vidaplayer = 100;

    [SerializeField] bool powerup = true;
    void Start()
    {
        // Exercico

        if (vidaplayer >= 0 && powerup == true)
        {
            vidaplayer = vidaplayer / 2;
            //print("Ainda não, vida atual: " + vidaplayer);
        }
        else
        {
            print("Game Over");
        }
    }

    void Update()
    {

    }
}
