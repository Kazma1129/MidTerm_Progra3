using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GameObject[] circles;
    private bool gamePause = true;
    public static int _currentIndex;

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
        //Print the time of when the function is first called.
       // Debug.Log("Started Coroutine at timestamp : " + Time.time);

        _currentIndex = Random.Range(0, circles.Length);
        Instantiate(circles[_currentIndex]);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        gamePause = true;


        //After we have waited 5 seconds print the time again.
     //   Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
