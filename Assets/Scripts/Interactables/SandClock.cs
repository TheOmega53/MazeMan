using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandClock : Interactable {

    public Animator animator;
    public GameObject particles;
    public float clockTime = 60;
    public Countdown UI_Counter;
    public MugJuggler juggler;
    private int keyState = 1;
    public Animator keyAnimator;


    public override void Interact()
    {
        base.Interact();

        StartCoroutine(SandClockInteract());
    }

    private void Start()
    {
        animator = this.GetComponentInParent<Animator>();
        particles = this.transform.parent.GetComponentInChildren<ParticleSystem>().transform.gameObject;
        particles.SetActive(false);
        keyAnimator.gameObject.SetActive(false);
    }

    public IEnumerator SandClockInteract()
    {
        if(keyAnimator.gameObject != null)
        {
            if (!animator.GetBool("IsCounting"))
            {
                animator.SetBool("IsCounting", true);
                particles.SetActive(true);
                keyAnimator.gameObject.SetActive(true);

                Juggle();
                yield return new WaitForSeconds(0.5f);
                Juggle();
                yield return new WaitForSeconds(0.5f);
                Juggle();

                UI_Counter.StartCounter(clockTime);
                yield return new WaitForSeconds(clockTime);
                animator.SetBool("IsCounting", false);
                particles.SetActive(false);
            }
            else
            {
                UI_Counter.StartCounter(0);
                animator.SetBool("IsCounting", false);
                particles.SetActive(false);
            }
        } else
        {
            Debug.Log("You have already solved the puzzle!");
        }




    }

    private void Juggle()
    {
        keyState = UnityEngine.Random.Range(1, 4);
        juggler.StartCoroutine(juggler.Juggle(keyState));
        keyAnimator.SetTrigger(keyState.ToString());
    }
}
