using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

    #region Singleton
    public static ItemManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    #endregion

    Item[] currentItems;

    private void Start()
    {
        currentItems = new Item[18];  //Array with the size of Inventory Slots
        //TODO: Make Array length dynamic
    }
}
