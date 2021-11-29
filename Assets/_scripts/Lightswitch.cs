using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Material[] materials;
    public GameObject lightswitch;

    private bool active = false;
    private GameObject[] lightswitchGOs;
    private Renderer lightswitchRenderer;

    void Start()
    {
        lightswitchGOs = GameObject.FindGameObjectsWithTag("lightswitch");
        lightswitchRenderer = lightswitch.GetComponent<Renderer>();
    }

    public void LightswitchInteraction()
    {
        foreach (GameObject go in lightswitchGOs)
            go.SetActive(active);

        lightswitchRenderer.material = materials[active ? 1 : 0];

        active = !active;
    }
}
