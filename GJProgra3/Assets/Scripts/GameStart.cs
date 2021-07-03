using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GameObject[] circles;
    private bool gamePause = true;
    public static int _currentIndex;
    public float tiempoEntreSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gamePause) {
            gamePause = false;
        StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
       
        // Elige cual circulo spawnear del array
        _currentIndex = Random.Range(0, circles.Length); 
        //instancea numero en base al resultado de la linea anterior
        Instantiate(circles[_currentIndex]);

        //espera por determinado numero de segundos //tiempo entre spawn
        yield return new WaitForSeconds(tiempoEntreSpawn);

        gamePause = true;


    }
}
