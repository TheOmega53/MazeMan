using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    #region Singleton
    public static PlayerManager instance;
    public Item[] itemsArray;


    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;


    public void SavePlayer()
    {

        SaveSystem.SavePlayer();
        Debug.Log("Checkpoint!!!!");
    }

    public void LoadPLayer()
    {

        PlayerData data = SaveSystem.LoadPlayer();

        // Vector3 position;
        float x = data.position[0];
        float y = data.position[1];
        float z = data.position[2];
        player.transform.position = new Vector3(x, y, z);
        Debug.Log(data.items);
        for (int i = 0; i < data.items.Length; i++)
        {
            for (int j = 0; j < itemsArray.Length; j++)
            {
                if (data.items[i] == itemsArray[j].name)
                {
                    Debug.Log(Inventory.instance.Add(itemsArray[j]));
                }
            }

        }
        Debug.Log("Load Successful");
    }
}
