using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject pauseUI;

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        PlayerManager.instance.player.GetComponent<FpsMovement>().enabled = false;
        pauseUI.GetComponent<InventoryUI>().enabled = false;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 1f;
            PlayerManager.instance.player.GetComponent<FpsMovement>().enabled = true;
            pauseUI.GetComponent<InventoryUI>().enabled = true;


        }


    }
}
