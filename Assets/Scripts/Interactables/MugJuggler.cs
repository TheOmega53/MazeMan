using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugJuggler : Interactable {

    Animator animator;
    private bool isJuggling = false;

    public override void Interact()
    {
        base.Interact();

        Lift(this.gameObject);
    }

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    private void Lift(GameObject mug)
    {
        switch (mug.name)
        {
            case "mug":
                animator.SetTrigger("Lift1");
                    break;

            case "mug (1)":
                animator.SetTrigger("Lift2");
                break;

            case "mug (2)":
                animator.SetTrigger("Lift3");
                break;
        }

    }
        

    public IEnumerator Juggle(int trigger)
    {
        if (!isJuggling){
            animator.SetTrigger(trigger.ToString());
            isJuggling = true;
            yield return new WaitForSeconds(1);
            isJuggling = false;
        }
    }
}
