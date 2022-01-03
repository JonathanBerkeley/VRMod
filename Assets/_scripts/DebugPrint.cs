using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPrint : MonoBehaviour
{
    public void DebugLog(string s)
    {
        Debug.Log(s);
    }

    public void DebugWarn(string s)
    {
        Debug.LogWarning(s);
    }

    public void DebugError(string s)
    {
        Debug.LogError(s);
    }
}
