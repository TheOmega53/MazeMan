﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class FlexibleUIButton : FlexibleUI {

    public enum ButtonType { TextButton, InventorySlot };
    public ButtonType type;

    public override void OnSkinUI()
    {
        base.OnSkinUI();

        Sprite _sprite;
        Image _image;
        TextMeshProUGUI _TMpro;



        _image = GetComponent<Image>();
        _sprite = _image.sprite;
        _TMpro = GetComponentInChildren<TextMeshProUGUI>();

        _sprite = skinData.defaultSprite;
        _image.color = skinData.defaultColor;
        _image.type = Image.Type.Sliced;
        _image.sprite = _sprite;

        if (type == ButtonType.TextButton) 
        {
            _TMpro.enableVertexGradient = skinData.isGradient;
            _TMpro.colorGradient = skinData.GradientPreset;
        }

        if(type == ButtonType.InventorySlot)
        {
            GetComponentInParent<InventorySlot>().selectedColor = skinData.SelectedColor;
            GetComponentInParent<InventorySlot>().unSelectedColor = skinData.defaultColor;
        }
    }

    public override void PlayOnHighlight()
    {
        base.PlayOnHighlight();

        AudioClip selectedSound = skinData.selectedSound;
        audioSource.PlayOneShot(selectedSound);
    }

    public override void PlayOnPressed()
    {
        base.PlayOnPressed();

        AudioClip pressedSound = skinData.pressedSound;
        audioSource.PlayOneShot(pressedSound);
    }
}
