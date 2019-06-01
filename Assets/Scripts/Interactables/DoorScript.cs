using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable {

    //public bool isOpen = false;
    private Animator animator;


    public override void Interact()
    {
        base.Interact();

        ToggleDoor();

    }

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    public void ToggleDoor()
    {
        if (!animator.GetBool("isOpen"))
        {
            if(Inventory.instance.activeItem != null)
            {
                if (Inventory.instance.activeItem.name == "Golden Key")
                {
                    //isOpen = true;
                    animator.SetBool("isOpen", true);
                } else
                {
                    Debug.Log("You need a key to open this door");
                }
            }
        }
        else
        {
            //isOpen = false;
            animator.SetBool("isOpen", false);

        }
    }
}
