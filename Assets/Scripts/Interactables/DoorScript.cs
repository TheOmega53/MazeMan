using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable {

    public bool isOpen = false;
    public float rotationSpeed;

    public MazeCell cell, otherCell;

    public MazeDirection direction;

    public override void Interact()
    {
        base.Interact();

        if (!isOpen)
        {
            if(Inventory.instance.usingItem)//TODO: AND item is key
                OpenDoor();
        } else
        {
            CloseDoor();
        };
    }

    void OpenDoor()
    {
        /*Quaternion rotation = Quaternion.LookRotation(transform.forward);
        rotation = Quaternion.Euler(0f, 90f, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation,  rotationSpeed);*/
        transform.rotation *= Quaternion.Euler(0, 80f * rotationSpeed , 0);
        isOpen = true;
    }

    void CloseDoor()
    {
        /*Quaternion rotation = Quaternion.LookRotation(transform.forward);
        rotation = Quaternion.Euler(0f, -90f, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation,  rotationSpeed);*/
        transform.rotation *= Quaternion.Euler(0, -80f * rotationSpeed , 0);

        isOpen = false;
    }



    public void Initialize(MazeCell cell, MazeCell otherCell, MazeDirection direction)
    {
        this.cell = cell;
        this.otherCell = otherCell;
        this.direction = direction;
        transform.parent = cell.transform;
        transform.localPosition = new Vector3(-0.5f, 0.5f,-0.5f);
        transform.localRotation = direction.ToRotation();
    }
}
