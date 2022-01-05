using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunfireEffect : MonoBehaviour
{
    public GameObject launchEffect;
    public GameObject startPoint;

    private GameObject launchObject;
    private List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

    private void Start()
    {
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(UnityEngine.XR.InputDeviceCharacteristics.HeldInHand, devices);
    }

    public void Fire()
    {
        //Launch particle effect
        launchObject = Instantiate(launchEffect, startPoint.transform.position, startPoint.transform.rotation);

        foreach (var device in devices)
        {
            uint channel = 0;
            float amplitude = 0.6f;
            float duration = 0.3f;
            device.SendHapticImpulse(channel, amplitude, duration);
        }

        //Cleanup for efficiency
        Destroy(launchObject, 2);
    }
}