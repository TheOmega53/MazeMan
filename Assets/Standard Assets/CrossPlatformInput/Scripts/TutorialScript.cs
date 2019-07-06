using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

    public GameObject TutorialUI;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel") || Input.GetButtonDown("Submit"))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 1f;            
        }


    }
}
