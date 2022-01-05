using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimation : MonoBehaviour
{
    public Vector3 to;
    public Vector3 from;

    private bool _enabled = false;

    private void Update()
    {
        if (_enabled)
        {
            gameObject.transform.localPosition = to;
        }
        else
        {
            gameObject.transform.localPosition = from;
        }
    }

    public void Clicked()
    {
        _enabled = !_enabled;
    }

    
}
