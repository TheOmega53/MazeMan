using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeDrawersRight : WardrobeScript {

    public override void InteractWardrobe()
    {
        base.InteractWardrobe();
        if (!animator.GetBool("RDrawerIsOpen"))
        {
            animator.SetBool("RDrawerIsOpen", true);
        }
        else
        {
            animator.SetBool("RDrawerIsOpen", false);
        }
    }
}
