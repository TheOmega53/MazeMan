using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour {

    public void onValueChanged()
    {
        AudioListener.volume = this.GetComponent<Slider>().value;
    }
}
