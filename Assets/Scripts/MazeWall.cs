using UnityEngine;


[ExecuteInEditMode]
public class MazeWall : MazeCellEdge {

    public WallData wallData;
    private WallType type;


    public override void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        base.Initialize(cell, otherCell, direction);

        /*type = wallData.Wallprefab;
        WallType wallObject = GameObject.Instantiate(type) as WallType;
        wallObject.transform.parent = this.transform;
        wallObject.transform.localPosition = new Vector3(0f,0f,0.5f);
        wallObject.transform.localRotation = Quaternion.Euler(0,0,0);
        */

    }

    
    private void Start()
    {
        WallData defaultWall = GetComponentInParent<Maze>().defaultWalls;
        if (defaultWall)
        {
            wallData = defaultWall;
            Debug.Log("Overriding wall data with default wall data");
        }

        if (GetComponentInChildren<WallType>() == null)
        {
            Create();
        } else if(GetComponentInChildren<WallType>() != wallData) {
            DestroyImmediate(GetComponentInChildren<WallType>().gameObject);
            Create();
        }
    }


    public void Create()
    {
        type = wallData.Wallprefab;
        WallType wallObject = GameObject.Instantiate(type) as WallType;
        wallObject.transform.parent = this.transform;
        wallObject.transform.localPosition = new Vector3(0f, 0f, 0.5f);
        wallObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}