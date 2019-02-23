using UnityEngine;
using UnityEngine.SceneManagement;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	public Transform itemsParent;	// The parent object of all the items
	public GameObject inventoryUI;	// The entire UI
    public GameObject itemActivationUI;  //to show an item is being used

	Inventory inventory;	// Our current inventory

	InventorySlot[] slots;	// List of all the slots

    private bool gameIsPaused;

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
            CursorManager.instance.Toggle();

            // Check to see if we should open/close the inventory
            inventoryUI.SetActive(!inventoryUI.activeSelf);

            //Check to see if game is paused
            if (!gameIsPaused)
            {
                Time.timeScale = 0f;
                gameIsPaused = true;
            } else
            {
                Time.timeScale = 1f;
                gameIsPaused = false;
            }
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
        CursorManager.instance.Lock();
        if (gameIsPaused)
        {
            Time.timeScale = 1f;
            gameIsPaused = false;
        }
        inventoryUI.SetActive(!inventoryUI.activeSelf); //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
    }

    public void MainMenu()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 1f;
            gameIsPaused = false;
        }
        SceneManager.LoadScene("MainMenu");
    }
}