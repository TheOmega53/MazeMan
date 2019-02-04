using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//rotates the gameobject continuously. 

public class FSP_ContinuousRotation : MonoBehaviour
{
    public GameObject cube;
    public float movementSpeed = 4;

    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "trap")
        {
            //Replace 'Game Over' with your game over scene's name.
            SceneManager.LoadScene("test");
        }
    }

  
        private void Start()
        {
            
        }

        void Update()
        {
            transform.LookAt(cube.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }


    
   
}