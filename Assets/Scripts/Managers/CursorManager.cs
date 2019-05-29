using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {


    #region Singleton
    public static CursorManager instance;


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }
    #endregion

    public GameObject cursorUI;

    public void Toggle()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            Lock();
        }
        else if (Cursor.lockState == CursorLockMode.Locked)
        {
            Unlock();
        }
    }

    public void Lock()
    {
        cursorUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Unlock()
    {
        cursorUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
