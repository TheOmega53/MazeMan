using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {

    #region Singleton
    public static PuzzleManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public bool inPuzzle;

}
