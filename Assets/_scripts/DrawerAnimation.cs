using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerAnimation : MonoBehaviour
{
    public Vector3 to;
    
    private Vector3 from;
    private bool _enabled = false;

    private void Awake()
    {
        from = gameObject.transform.position;
    }

    private void Update()
    {
        if (enabled)
        {
            Vector3.MoveTowards(from, to, 1.0f * Time.deltaTime);
        }
        else
        {
            Vector3.MoveTowards(to, from, 1.0f * Time.deltaTime);
        }
    }

    public void Clicked()
    {
        _enabled = !_enabled;
    }

    
}
