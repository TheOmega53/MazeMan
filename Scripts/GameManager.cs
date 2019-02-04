using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Maze mazePrefab;

    private Maze mazeInstance;

    public bool KeyActive;


    private void Start()
    {
        BeginGame();
        KeyActive = false;
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //RestartGame();
        //}

        
    }

    private void BeginGame() {
        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate());
    }

    private void RestartGame() {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}