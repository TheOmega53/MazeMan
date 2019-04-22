using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Wall Data",menuName = "Wall Data")]
public class WallData : ScriptableObject {


    public Vector3 Scale;

    public MazeWall Wallprefab;
	
}
