using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Player Entered" + this.name);

            GetComponentInParent<MazeCell>().ActivateMinimap();
            //TODO: Triggers here
        }
    }
}
