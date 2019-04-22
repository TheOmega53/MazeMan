using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable {

    public bool isOpen = false;
    public float rotationSpeed;

    public MazeCell cell, otherCell;


    public override void Interact()
    {
        base.Interact();

        ToggleDoor();

    }

    void ToggleDoor()
    {
        if (!isOpen)
        {
            if(Inventory.instance.activeItem != null)
            {
                if (Inventory.instance.activeItem.name == "Golden Key")
                {
                    transform.rotation *= Quaternion.Euler(0, 80f * rotationSpeed, 0);
                    isOpen = true;
                }
            }
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, -80f * rotationSpeed, 0);
            isOpen = false;
        }
    }
}
