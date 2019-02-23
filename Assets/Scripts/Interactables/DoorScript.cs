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

        toggleDoor();

    }

    void toggleDoor()
    {
        if (!isOpen)
        {
            if (Inventory.instance.usingItem)
            {
                transform.rotation *= Quaternion.Euler(0, 80f * rotationSpeed, 0);
                isOpen = true;
            }
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, -80f * rotationSpeed, 0);
            isOpen = false;
        }
    }
}
