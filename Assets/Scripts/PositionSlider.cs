using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class PositionSlider : MonoBehaviour {
    public static PositionSlider instance;
    public AudioMixerSO audioMixerSOGeneral;
    public AudioMixerSO audioMixerSOMusic;
    public AudioMixerSO audioMixerSOSFX;
    public Slider sliderGeneral;
    public Slider sliderMusic;
    public Slider sliderSFX;
    private void Awake()
    {
        if(instance == null )
        {
            instance = this;
            DontDestroyOnLoad(gameObject );
        }
        else
        {
            Destroy(gameObject);
        }
    }
 




    private void Start()
    {
       sliderGeneral.value =   audioMixerSOGeneral.GetCurrentVolumeValue();
       sliderMusic.value =   audioMixerSOMusic.GetCurrentVolumeValue();
       sliderSFX.value =   audioMixerSOSFX.GetCurrentVolumeValue();


    }



}
