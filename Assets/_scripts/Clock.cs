using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject[] hands;

    private System.DateTime dateTime;

    private void Start()
    {
        print(System.DateTime.Now);
    }

    void Update()
    {
        dateTime = System.DateTime.Now;
        Vector3 secondRot = new Vector3(6.0f * dateTime.Second, 0.0f, 0.0f);
        hands[2].transform.localRotation = Quaternion.Euler(secondRot);

        Vector3 minuteRot = new Vector3(6.0f * dateTime.Minute, 0.0f, 0.0f);
        hands[1].transform.localRotation = Quaternion.Euler(minuteRot);

        Vector3 hourRot = new Vector3(30.0f * dateTime.Hour, 0.0f, 0.0f);
        hands[0].transform.localRotation = Quaternion.Euler(hourRot);
    }
}
