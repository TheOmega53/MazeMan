using UnityEngine;

public abstract class  MazeCellEdge : MonoBehaviour
{
    
    [SerializeField] private MazeCell cell, otherCell;

    [SerializeField] private MazeDirection direction;

    public virtual void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        this.cell = cell;
        this.otherCell = otherCell;
        this.direction = direction;
        cell.SetEdge(direction, this);
        transform.parent = cell.transform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = direction.ToRotation();
    }




}

