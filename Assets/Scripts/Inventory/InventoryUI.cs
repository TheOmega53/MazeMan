using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;	// The entire UI
    public GameObject itemActivationUI;  //to show an item is being used
    public GameObject lockedCursor;  //The in-game cursor
    public InventorySlot selectedSlot;

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
            CursorManager.instance.toggleCursorMode();

            // Check to see if we should open/close the inventory
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            lockedCursor.SetActive(!lockedCursor.activeSelf);

            inventory.usingItem = false;
            selectedSlot = null;
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


    public void Resume()
    {
        //lock cursor
        CursorManager.instance.lockCursor();

        //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
        inventoryUI.SetActive(!inventoryUI.activeSelf);
        lockedCursor.SetActive(!lockedCursor.activeSelf);

        if(selectedSlot != null)
        {
            selectedSlot.GetComponentInChildren<Image>().color = selectedSlot.unSelectedColor;
        }

    }

    public void Use()
    {
        //lock cursor
        CursorManager.instance.lockCursor();

        //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
        inventoryUI.SetActive(!inventoryUI.activeSelf);
        lockedCursor.SetActive(!lockedCursor.activeSelf);

        if(selectedSlot != null)
        {
            selectedSlot.GetComponentInChildren<Image>().color = selectedSlot.unSelectedColor;
            selectedSlot.UseItem();
        }


        //TODO: Implement using the active item
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}