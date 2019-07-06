using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeDrawersLeft : WardrobeScript
{

    public override void InteractWardrobe()
    {
        base.InteractWardrobe();
        if (!animator.GetBool("LDrawerIsOpen"))
        {
            animator.SetBool("LDrawerIsOpen", true);
        }
        else
        {
            animator.SetBool("LDrawerIsOpen", false);
        }
    }
}
