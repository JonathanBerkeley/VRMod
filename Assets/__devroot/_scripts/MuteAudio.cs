using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public AudioSource[] sources;

    private bool active = true;

    public void Clicked()
    {
        foreach (var source in sources)
        {
            source.mute = active;
        }
        active = !active;
    }
}
