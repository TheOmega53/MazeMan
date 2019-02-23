using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public Transform target;  //the enemy's target
    public float moveSpeed = 3; //move speed
    public float rotationSpeed = 3; //speed of turning
    public float range = 10f;
    public float range2 = 10f;
    public float stop = 0;
    public Transform myTransform; //current transform data of this enemy
    void Awake()
    {
        myTransform = transform; //cache transform data for easy access/preformance
    }

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; //target the player

    }

    void Update()
    {
        myTransform.position =new Vector3(myTransform.position.x, 0, myTransform.position.z);
        //myTransform.eulerAngles = new Vector3(myTransform.eulerAngles.x, 0, myTransform.eulerAngles.z);
        //rotate to look at the player
        var distance = Vector3.Distance(myTransform.position, target.position);
        if (distance <= range2 && distance >= range)
        {
            Vector3 direction = (target.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);

        }


        else if (distance <= range && distance > stop)
        {

            //move towards the player
            Vector3 direction = (target.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);

            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
        else if (distance <= stop)
        {
            Vector3 direction = (target.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
        }


    }

    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "Player")
        {
            //Replace 'Game Over' with your game over scene's name.
            CursorManager.instance.Unlock();
            Debug.Log("Cursor unlocked");
            SceneManager.LoadScene("GameOver");
        }
    }
}