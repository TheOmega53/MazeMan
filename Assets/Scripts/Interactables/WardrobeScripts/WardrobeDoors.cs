using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeDoors : WardrobeScript
{
    public override void InteractWardrobe()
    {
        base.InteractWardrobe();
        if (!animator.GetBool("IsOpen"))
        {
            animator.SetBool("IsOpen", true);
        }
        else if(!animator.GetBool("LDrawerIsOpen") && !animator.GetBool("RDrawerIsOpen"))
        {
            animator.SetBool("IsOpen", false);
        }
    }
}
