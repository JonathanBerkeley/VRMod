using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSBlock : MonoBehaviour
{
    public AudioSource hit;
    public PlayerStats ps;
    public int damage = 10;

    private void Start()
    {
        ps = FindObjectOfType<PlayerStats>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bot")
        {
            hit.Play();
            ps.TakeDamage(damage);
        }
    }
}
