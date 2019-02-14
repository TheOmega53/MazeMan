using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(menuName = "Flexible UI Button Data")]

public class FlexibleUIData : ScriptableObject {

    public Sprite defaultSprite;
    public Color defaultColor;
    public Color SelectedColor;
    public AudioClip selectedSound;
    public AudioClip pressedSound;

    public bool isGradient;
    public VertexGradient GradientPreset;

    
    
}