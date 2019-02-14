using UnityEngine;
using UnityEngine.UI;

/* Sits on all InventorySlots. */

public class InventorySlot : MonoBehaviour {

	public Image icon;          // Reference to the Icon image
    public InventoryUI inventoryUI;
    public Color selectedColor;
    public Color unSelectedColor;




    Item item;  // Current item in the slot

	// Add item to the slot
	public void AddItem (Item newItem)
	{
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
	}

	// Clear the slot
	public void ClearSlot ()
	{
		item = null;

		icon.sprite = null;
		icon.enabled = false;
	}



	// Called when the item is pressed
	public void UseItem ()
	{

		if (item != null)
		{
            item.Use();
            //TODO: create USE button to do this.
        }    
	}
    
    public void Select()
    {
        inventoryUI.selectedSlot = this;
        if (item != null)
        {
            this.GetComponentInChildren<Image>().color = selectedColor;
        }
            
    }
}