using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public void Resume(){
        //lock cursor
        CursorManager.instance.lockCursor();

        //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
        //inventoryUI.SetActive(!inventoryUI.activeSelf);
	}

    public void Use() {
        //lock cursor
        CursorManager.instance.lockCursor();

        //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
        //inventoryUI.SetActive(!inventoryUI.activeSelf);

        //TODO: Implement using the active item
    }

	public void MainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
