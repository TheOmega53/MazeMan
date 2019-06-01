using System;
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

            if (transform.parent.gameObject.transform.GetComponentInChildren<DoorScript>() != null)
            {
                Debug.Log("Beginning puzzle sequence");
                if (!PuzzleManager.instance.inPuzzle)
                {
                    StartCoroutine(BeginPuzzleSeq());
                    PuzzleManager.instance.inPuzzle = true;
                }
            }
            
            //TODO: Triggers here
        }
    }

    private IEnumerator BeginPuzzleSeq()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Automatically closing door");
        transform.parent.gameObject.transform.GetComponentInChildren<DoorScript>().ToggleDoor();
        //Start the timer, etc
    }
}
