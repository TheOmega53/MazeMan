 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell : MonoBehaviour {

    public IntVector2 coordinates;

    private MazeCellEdge[] edges = new MazeCellEdge[MazeDirections.Count];

    private int initializedEdgeCount;

    private BoxCollider boxCollider;
    private MinimapLayout[] layouts;


    public MazeCellEdge GetEdge(MazeDirection direction)
    {
        return edges[(int)direction];
    }

    public bool IsFullyInitialized
    {
        get
        {
            return initializedEdgeCount == MazeDirections.Count;
        }
    }

    public void SetEdge(MazeDirection direction, MazeCellEdge edge)
    {
        edges[(int)direction] = edge;
        initializedEdgeCount += 1;
    }

    public MazeDirection RandomUninitializedDirection
    {
        get
        {
            int skips = Random.Range(0, MazeDirections.Count - initializedEdgeCount);
            for (int i = 0; i < MazeDirections.Count; i++)
            {
                if (edges[i] == null)
                {
                    if (skips == 0)
                    {
                        return (MazeDirection)i;
                    }
                    skips -= 1;
                }
            }
            throw new System.InvalidOperationException("MazeCell has no uninitialized directions left.");
        }
    }

    private void Start()
    {
        layouts = this.GetComponentsInChildren<MinimapLayout>();

        for (int i = 0; i < layouts.Length; i++)
        {
            layouts[i].Deactivate();
        }

    }

    public void ActivateMinimap()
    {
            for (int i = 0; i < layouts.Length ; i++){
                layouts[i].Activate();
            }
    }

    public void ToggleDoors()
    {

        DoorScript[] Doors = GetComponentsInChildren<DoorScript>();
        foreach (DoorScript d in Doors)
        {
            d.Close();
        }
    }
}


