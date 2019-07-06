using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleKey : Interactable {

    public Item item;   // Item to put in the inventory on pickup
    public SandClock clock; //The clock to end the puzzle sequence

    // When the player interacts with the item
    public override void Interact()
    {
        base.Interact();

        PickUp();   // Pick it up!
    }

    // Pick up the item
    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);    // Add to inventory

        // If successfully picked up
        if (wasPickedUp)
        {
            StopCoroutine(clock.SandClockInteract());
            clock.UI_Counter.StartCounter(0);
            clock.animator.SetBool("IsCounting", false);
            clock.particles.SetActive(false);
            Destroy(gameObject);    // Destroy item from scene
            PlayerManager.instance.SavePlayer();
        }
            
    }
}
