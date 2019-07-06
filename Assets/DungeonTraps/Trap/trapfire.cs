using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapfire : MonoBehaviour
{

    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "Player")
        {
            //Replace 'Game Over' with your game over scene's name.
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter(Collider exampleCol)
    {
        if (exampleCol.tag == "Player")
        {
            //Replace 'Game Over' with your game over scene's name.
            SceneManager.LoadScene("GameOver");
        }
    }
}