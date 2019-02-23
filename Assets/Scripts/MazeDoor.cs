using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeDoor : MazeCellEdge {

    public override void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        base.Initialize(cell, otherCell, direction);

        switch ((int)direction)
        {
            case 0:
                transform.localPosition = new Vector3(-0.5f, 0.5f, 0.5f);
                break;

            case 1:
                transform.localPosition = new Vector3(0.5f, 0.5f, 0.5f);
                break;

            case 2:
                transform.localPosition = new Vector3(0.5f, 0.5f, -0.5f);
                break;

            case 3:
                transform.localPosition = new Vector3(-0.5f, 0.5f, -0.5f);
                break;
        }
    }
}
