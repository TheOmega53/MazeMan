using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CellTrigger : MonoBehaviour {

    public UnityEvent triggerEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Player Entered" + this.name);

            GetComponentInParent<MazeCell>().ActivateMinimap();


            if (triggerEvents != null)
            {
                triggerEvents.Invoke();
            }
            //TODO: Triggers here
        }
    }
}
