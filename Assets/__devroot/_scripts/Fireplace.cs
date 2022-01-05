using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : MonoBehaviour
{
    private bool active = false;
    private GameObject[] fireplaceGOs;

    void Start()
    {
        fireplaceGOs = GameObject.FindGameObjectsWithTag("fireplace");
    }

    public void FireplaceInteraction()
    {
        foreach(GameObject go in fireplaceGOs)
            go.SetActive(active);

        active = !active;
    }
}
