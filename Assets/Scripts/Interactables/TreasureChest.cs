using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : Interactable {

    Animator animator;

    public override void Interact()
    {
        base.Interact();

        TreasureInteract();
    }

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    private void TreasureInteract()
    {
        if (!animator.GetBool("IsOpen"))
        {
            animator.SetBool("IsOpen", true);
        } else
        {
            animator.SetBool("IsOpen", false);
        }
    }
}
