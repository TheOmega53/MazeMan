using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject inventoryUI;

	public void Resume(){
		inventoryUI.SetActive(!inventoryUI.activeSelf); //it has the same functionality as pressing "Inventory key input" (which is "i" or "b" keys in this case)
	}

	public void MainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
