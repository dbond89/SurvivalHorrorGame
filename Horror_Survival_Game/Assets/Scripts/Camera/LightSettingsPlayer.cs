using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour
{
    [SerializeField] PostProcessVolume MyVolume;

    //Standard Profile that lights the scene
    [SerializeField] PostProcessProfile StandardProfile; 
    //Profile used when player toggles the Night-vision goggles on
    [SerializeField] PostProcessProfile NightVisionProfile;
    //The GUI overlay used when NightVisionProfile is active
    [SerializeField] GameObject NightVisionOverlay;
    [SerializeField] GameObject Flashlight;
    
    //NightVisionActive true when toggled on, default false
    private bool NightVisionActive = false;
    //FlightlightActive true when toggled on, default false
    private bool FlashlightActive = false;

    private void Start()
    {
        NightVisionOverlay.gameObject.SetActive(false);
        Flashlight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Toggles NightVision on/off by pressing 'N'
        if(Input.GetKeyDown(KeyCode.N))
        {
            ToggleNightVision();
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
    }

    private void ToggleFlashlight()
    {
        if(!FlashlightActive)
        {
            Flashlight.SetActive(true);
            FlashlightActive = true;
        }
        else
        {
            Flashlight.SetActive(false);
            FlashlightActive = false;
        }
    }

    /* 
     * Toggles Night-vision mode on/off
     * Default: NightVisionActive is false
     */
    void ToggleNightVision()
    {
        //if NightVision not currently active
        if(!NightVisionActive)
        {
            MyVolume.profile = NightVisionProfile;
            NightVisionActive = true;
            NightVisionOverlay.gameObject.SetActive(true);
        }
        //if NightVision currently active
        else
        {
            MyVolume.profile = StandardProfile;
            NightVisionActive = false;
            NightVisionOverlay.gameObject.SetActive(false);
        }
    }

}
