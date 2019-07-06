using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : Interactable {

    //public bool isOpen = false;
    private Animator animator;


    public override void Interact()
    {
        base.Interact();

        UseDoor();

    }

    private void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    public void UseDoor()
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

    public void Open()
    {
        if (!animator.GetBool("isOpen"))
        {
            animator.SetBool("isOpen", true);
        }
    }

    public void Close()
    {
        if (animator.GetBool("isOpen"))
        {
            animator.SetBool("isOpen", false);
        }
    }
}
