using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour {

    public TextMeshProUGUI TMP;
    float timeLeft;

	// Use this for initialization
	void Start () {
        TMP = GetComponentInChildren<TextMeshProUGUI>();
        TMP.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            TMP.gameObject.SetActive(false);
        }
        TMP.text = timeLeft.ToString();
    }

    public void StartCounter(float time)
    {
        TMP.gameObject.SetActive(true);
        timeLeft = time;
    }
}
