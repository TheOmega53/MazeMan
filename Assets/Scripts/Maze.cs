using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour {

    public MazeCell cellPrefab;

    private MazeCell[,] cells;

    public float generationStepDelay;

    public IntVector2 size;

    public MazePassage passagePrefab;
    public MazeWall wallPrefab;
    public DoorScript doorPrefab;
    public Enemy enemyPrefab;
    public ItemPickup KeyPrefab;

    public CostumMaze costumMaze;


    // Use this for initialization
    void Start() {

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
        //DoFirstGenerationStep(activeCells);
        while (activeCells.Count > 0)
        {
            yield return delay;
            //DoNextGenerationStep(activeCells);
        }
    }

    private void CreatePassage(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        MazePassage passage = Instantiate(passagePrefab) as MazePassage;
        passage.Initialize(cell, otherCell, direction);
        passage = Instantiate(passagePrefab) as MazePassage;
        passage.Initialize(otherCell, cell, direction.GetOpposite());
    }

    private void CreateWall(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        MazeWall wall = Instantiate(wallPrefab) as MazeWall;
        wall.Initialize(cell, otherCell, direction);
        if (otherCell != null)
        {
            wall = Instantiate(wallPrefab) as MazeWall;
            wall.Initialize(otherCell, cell, direction.GetOpposite());
        }
    }

    private void CreateDoor(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        DoorScript door = Instantiate(doorPrefab) as DoorScript;
        door.Initialize(cell, otherCell, direction);
    }

    /*
        public IntVector2 RandomCoordinates
        {
            get
            {
                return new IntVector2(Random.Range(0, size.x), Random.Range(0, size.z));
            }
        }
     */

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

        if (NorthWall == true) CreateWall(newCell, null, (MazeDirection)0);
        if (EastWall == true) CreateWall(newCell, null, (MazeDirection)1);
        if (SouthWall == true) CreateWall(newCell, null, (MazeDirection)2);
        if (WestWall == true) CreateWall(newCell, null, (MazeDirection)3);



        return newCell;
    }


    private void CreateEnemy(IntVector2 coordinates)
    {
        Enemy newEnemy = Instantiate(enemyPrefab) as Enemy;
        newEnemy.transform.position = cells[coordinates.x, coordinates.z].transform.position;

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
                walls = costumMaze.getCell(coordinates);
                CreateCell(coordinates, walls[0], walls[1], walls[2], walls[3]);
            }
        }

        List<IntVector2> EnemyCoordinates = costumMaze.getEnemyCoordinates();
        foreach(IntVector2 coordinate in EnemyCoordinates)
        {
            CreateEnemy(coordinate);
        }

        List<IntVector2> KeyCoordinates = costumMaze.getKeyCoordinates();
        foreach (IntVector2 coordinate in KeyCoordinates)
        {
            CreateKey(coordinate);
        }

        List<int[]> DoorCoordinates = costumMaze.getDoorCoordinates();
        foreach(int[] coordinate in DoorCoordinates)
        {
            MazeCell cell = cells[coordinate[0], coordinate[1]];
            CreateDoor(cell, null, (MazeDirection)coordinate[2]);
        }

    }




}

