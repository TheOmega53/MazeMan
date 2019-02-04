using UnityEngine;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;	// The entire UI
    public GameObject itemActivationUI;  //to show an item is being used

	Inventory inventory;	// Our current inventory

	InventorySlot[] slots;	// List of all the slots

	void Start () {
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;	// Subscribe to the onItemChanged callback

		// Populate our slots array
		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}

	void Update () {
		// Check to see if we should open/close the inventory
		if (Input.GetButtonDown("Cancel"))
		{
            //Changing between the 2 different cursor lock states
            if(Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }

            if (Cursor.lockState == (CursorLockMode.Locked))
            {
                Cursor.lockState = CursorLockMode.None;
            }
            Cursor.lockState = CursorLockMode.None;

            // Check to see if we should open/close the inventory

            inventoryUI.SetActive(!inventoryUI.activeSelf);
		}
        if (!itemActivationUI.activeSelf)
        {
            if (inventory.usingItem)
            {
                itemActivationUI.SetActive(true);
            }
        }
        else if (!inventory.usingItem)
        {
            itemActivationUI.SetActive(false);
        }
        

    }

	// Update the inventory UI by:
	//		- Adding items
	//		- Clearing empty slots
	// This is called using a delegate on the Inventory.
	void UpdateUI ()
	{
		Debug.Log("Updating UI");

		for (int i = 0; i < slots.Length; i++)
		{
			if (i < inventory.items.Count)	// If there is an item to add
			{
				slots[i].AddItem(inventory.items[i]);	// Add it
			} else
			{
				// Otherwise clear the slot
				slots[i].ClearSlot();
			}
		}
	}
}