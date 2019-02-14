using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;


[ExecuteInEditMode]
public class FlexibleUI : MonoBehaviour {

    public FlexibleUIData skinData;
    public AudioSource audioSource;

    public virtual void OnSkinUI()
    {
        //This is meant to be filled
    }

    public virtual void Submit()
    {

    }

    public virtual void PlayOnHighlight()
    {
        //This is meant to be filled by children
        //This method will be called by Animation Events
    }

    public virtual void PlayOnPressed()
    {
        //This is meant to be filled by children
        //This method will be called by Animation Events
    }

    public virtual void Awake()
    {
        OnSkinUI();
    }

    public virtual void Update()
    {
        if (Application.isEditor) 
        {
            //For test purposes, show changes in the editor.
            //OnSkinUI();
        }
    }
}
