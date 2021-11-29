using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSwivel : MonoBehaviour
{
    public GameObject chair;

    void Update()
    {
        chair.transform.eulerAngles = new Vector3(
            chair.transform.eulerAngles.x,
            gameObject.transform.eulerAngles.y + 90,
            chair.transform.eulerAngles.z
        );
    }
}
