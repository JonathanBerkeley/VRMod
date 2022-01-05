using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLighting : MonoBehaviour
{
    public GameObject lighting;
    public float speed = -1.0f;

    void Update()
    {
        lighting.transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f, Space.Self);
    }
}
