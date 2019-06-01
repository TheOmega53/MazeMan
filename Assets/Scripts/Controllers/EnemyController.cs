using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

    public float lookRadius = 5f;

    Transform target;
    NavMeshAgent agent;
    Animator animator;

    public LayerMask rayMask;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        target = PlayerManager.instance.player.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(target.position, transform.position);

        Vector3 direction = Vector3.Normalize((target.transform.position - new Vector3(0, 0.2f, 0)) - transform.position);

        if(distance <= lookRadius)
        {
            FaceTarget();
            Ray ray = new Ray(transform.position, direction);
            RaycastHit hit;
            RaycastHit playerHit;


            Debug.DrawRay(transform.position, direction *2, color: Color.red, duration: 1f);

            if (Physics.Raycast(ray, out hit, 2, rayMask))
            {
                //Debug.Log(hit.collider.name);;
                if (hit.collider.tag == "Player")
                {
                    agent.SetDestination(target.position);
                    animator.SetBool("isRunning", true);
                    animator.SetBool("isAttacking", false);

                    if (distance <= agent.stoppingDistance)
                    {
                        //Face the target
                        FaceTarget();
                        animator.SetBool("isAttacking", true);

                        //if Character is in range after attack, Game over.
                        if (animator.GetCurrentAnimatorStateInfo(0).IsName("AfterAttack"))
                        {
                            if (distance <= agent.stoppingDistance)
                            {
                                GameOver();
                            }
                        }
                    }
                }
            }
        }
	}

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void GameOver()
    {
        //Replace 'Game Over' with your game over scene's name.
        CursorManager.instance.Unlock();
        Debug.Log("Cursor unlocked");
        SceneManager.LoadScene("GameOver");
    }
}
