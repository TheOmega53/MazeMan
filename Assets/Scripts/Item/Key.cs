using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Key", menuName = "Inventory/Key")]

public class Key : Item {
    public override void Use()
    {
       // GameManager.instance.KeyActive = true;

        Debug.Log(name + " used!");
        Inventory.instance.usingItem = true;
        //RemoveFromInventory();
        //TODO: Code Actual Key behaviour
    }
}
