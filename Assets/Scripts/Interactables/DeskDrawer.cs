using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskDrawer : Interactable {

    private Animator animator;

    public override void Interact()
    {
        base.Interact();

        InteractDesk();
    }

    private void Start()
    {
        animator = this.transform.parent.GetComponent<Animator>();
    }

    private void InteractDesk()
    {
        if (!animator.GetBool("DrawerIsOpen"))
        {
            animator.SetBool("DrawerIsOpen", true);
        }
        else
        {
            animator.SetBool("DrawerIsOpen", false);
        }
        
        
    }
}
