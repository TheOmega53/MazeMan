using UnityEngine;


[ExecuteInEditMode]
public class MazeWall : MazeCellEdge {

    public GameObject wallPrefab;


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
        GameObject defaultWall = GetComponentInParent<Maze>().defaultWalls;
        if (defaultWall)
        {
            wallPrefab = defaultWall;
            Debug.Log("Overriding wall data with default wall data");
        }

        if (GetComponentInChildren<Transform>())
        {
            foreach (Transform child in transform)
            {
                DestroyImmediate(child.gameObject);
            }
        }
        Create();

    }


        public void Create()
    {
        GameObject wallObject = GameObject.Instantiate(wallPrefab);
        wallObject.transform.parent = this.transform;
        wallObject.transform.localPosition = wallObject.transform.position;
        wallObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}