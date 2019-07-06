using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerData {
	
	public float[] position;
	public string[] items;
	
	public PlayerData (){
		
		position = new float[3];
		position[0] = PlayerManager.instance.player.transform.position.x ;
		position[1] = PlayerManager.instance.player.transform.position.y;
		position[2] = PlayerManager.instance.player.transform.position.z ;

		items = new string[Inventory.instance.items.Count];
		for(int i=0; i < Inventory.instance.items.Count; i++){
			items[i] = Inventory.instance.items[i].name;
		}
		
	} 
}
