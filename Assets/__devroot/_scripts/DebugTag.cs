using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTag : MonoBehaviour
{
    public string objectTag;
    
    void Start()
    {
        Debug.Log("DebugTag:" + objectTag);

        foreach (var obj in GameObject.FindGameObjectsWithTag(objectTag))
        {
            Debug.Log("DebugTag:" + obj);
        }
    }

}
