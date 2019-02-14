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

    private CursorLockMode wantedMode = CursorLockMode.Locked;
    private bool CursorVisibility;

    private void Start()
    {
        Cursor.lockState = wantedMode;
        Cursor.visible = false;

    }
    public void lockCursor()
    {
        wantedMode = CursorLockMode.Locked;
        CursorVisibility = false; //invisible
        Cursor.lockState = wantedMode;
        Cursor.visible = CursorVisibility;
    }

    public void unlockCursor()
    {
        wantedMode = CursorLockMode.Confined;
        CursorVisibility = true; //visible
        Cursor.lockState = wantedMode;
        Cursor.visible = CursorVisibility;
    }

    public void toggleCursorMode()
    {
        if(wantedMode == CursorLockMode.Locked)
        {
            unlockCursor();
        } else
        {
            lockCursor();
        }
    }

    //Use : CursorManager.instance.unlockCursor() or CursorManager.instance.lockCursor()
}
