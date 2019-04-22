using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public Maze mazePrefab;

    private Maze mazeInstance;

    public NavMeshSurface surface;
    private void Start()
    {
        BeginGame();

        //surface.BuildNavMesh();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            RestartGame();
        }

        
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