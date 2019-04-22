using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Maze : MonoBehaviour {

    public MazeCell cellPrefab;

    private MazeCell[,] cells;

    public float generationStepDelay;

    public IntVector2 size;

    public MazePassage passagePrefab;

    public MazeWall wallPrefab;
    public MazeWall stoneWallPrefab;
    public MazeWall woodenWallPrefab;


    public MazeDoor doorPrefab;
    public Enemy enemyPrefab;
    public ItemPickup KeyPrefab;

    public CostumMaze costumMaze;

    public NavMeshSurface surface;



    // Use this for initialization
    void Awake() {

        surface = GameObject.FindObjectOfType<NavMeshSurface>();
    }

    // Update is called once per frame
    void Update() {

    }

    public MazeCell GetCell(IntVector2 coordinates)
    {
        return cells[coordinates.x, coordinates.z];
    }

    public IEnumerator Generate()
    {
        WaitForSeconds delay = new WaitForSeconds(generationStepDelay);
        cells = new MazeCell[size.x, size.z];
        List<MazeCell> activeCells = new List<MazeCell>();
        CreateCostumMaze();
        while (activeCells.Count > 0)
        {
            yield return delay;
        }
    }

    private void CreatePassage(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        MazePassage passage = Instantiate(passagePrefab) as MazePassage;
        passage.Initialize(cell, otherCell, direction);
        passage = Instantiate(passagePrefab) as MazePassage;
        passage.Initialize(otherCell, cell, direction.GetOpposite());
    }


    public enum WallType
    {
        Bramble,
        Stone,
        Wooden
    }

    private void CreateWall(MazeCell cell, MazeCell otherCell, MazeDirection direction, WallType type = WallType.Bramble) //TODO: Add walltype
    {
        MazeWall wall;
        switch (type)
        {
            case WallType.Stone:
                wall = Instantiate(stoneWallPrefab) as MazeWall;
                break;

            case WallType.Wooden:
                wall = Instantiate(woodenWallPrefab) as MazeWall;
                break;

            default:
                wall = Instantiate(wallPrefab) as MazeWall;
                break;
        }
        //MazeWall wall = Instantiate(wallPrefab) as MazeWall;
        wall.Initialize(cell, otherCell, direction);
        if (otherCell != null)
        {
            wall = Instantiate(wallPrefab) as MazeWall;
            wall.Initialize(otherCell, cell, direction.GetOpposite());
        }
    }

    private void CreateDoor(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        MazeDoor door = Instantiate(doorPrefab) as MazeDoor;
        door.Initialize(cell, otherCell, direction);
    }

    public bool ContainsCoordinates(IntVector2 coordinate)
    {
        return coordinate.x >= 0 && coordinate.x < size.x && coordinate.z >= 0 && coordinate.z < size.z;
    }


    private MazeCell CreateCell(IntVector2 coordinates, bool NorthWall = false, bool EastWall = false, bool SouthWall = false, bool WestWall = false)
    {
        MazeCell newCell = Instantiate(cellPrefab) as MazeCell;
        cells[coordinates.x, coordinates.z] = newCell;
        newCell.coordinates = coordinates;
        newCell.name = "Maze Cell " + coordinates.x + ", " + coordinates.z;
        newCell.transform.parent = transform;
        newCell.transform.localPosition = new Vector3(coordinates.x - size.x * 0.5f + 0.5f, 0f, coordinates.z - size.z * 0.5f + 0.5f);

        WallType wallType = costumMaze.GetWallType(coordinates);
        if (NorthWall == true) CreateWall(newCell, null, (MazeDirection)0, wallType);
        if (EastWall == true) CreateWall(newCell, null, (MazeDirection)1, wallType);
        if (SouthWall == true) CreateWall(newCell, null, (MazeDirection)2, wallType);
        if (WestWall == true) CreateWall(newCell, null, (MazeDirection)3, wallType);



        return newCell;
    }


    private void CreateEnemy(IntVector2 coordinates)
    {
        Enemy newEnemy = Instantiate(enemyPrefab) as Enemy;
        newEnemy.transform.position = cells[coordinates.x, coordinates.z].transform.position;
        newEnemy.GetComponent<NavMeshAgent>().enabled = true;

    }

    private void CreateKey(IntVector2 coordinates)
    {
        ItemPickup newKey = Instantiate(KeyPrefab) as ItemPickup;
        newKey.transform.position = cells[coordinates.x, coordinates.z].transform.position;
    }


    public void CreateCostumMaze()
    {
        IntVector2 coordinates = new IntVector2(0, 0);
        bool[] walls = new bool[4];

        for (int z = 0; z < 30; z++)
        {
            for (int x = 0; x < 19; x++)
            {
                coordinates = new IntVector2(x, z);
                walls = costumMaze.GetCell(coordinates);
                CreateCell(coordinates, walls[0], walls[1], walls[2], walls[3]);
            }
        }

        surface.BuildNavMesh();

        List<IntVector2> EnemyCoordinates = costumMaze.GetEnemyCoordinates();
        foreach(IntVector2 coordinate in EnemyCoordinates)
        {
            CreateEnemy(coordinate);
        }

        List<IntVector2> KeyCoordinates = costumMaze.GetKeyCoordinates();
        foreach (IntVector2 coordinate in KeyCoordinates)
        {
            CreateKey(coordinate);
        }

        List<int[]> DoorCoordinates = costumMaze.GetDoorCoordinates();
        foreach(int[] coordinate in DoorCoordinates)
        {
            MazeCell cell = cells[coordinate[0], coordinate[1]];
            CreateDoor(cell, null, (MazeDirection)coordinate[2]);
        }

    }




}

