using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeScript : Interactable
{

    protected Animator animator;

    public override void Interact()
    {
        base.Interact();

        InteractWardrobe();

    }

    public virtual void InteractWardrobe()
    {
        //This is supposed to be filled differently for each part of the Wardrobe
    }

    void Start()
    {
        animator = this.GetComponentInParent<Animator>();
    }

}
