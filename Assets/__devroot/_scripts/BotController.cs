using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public float offsetAmount = 3.0f;
    public float botspeed = 5.0f;
    public float respawnTimer = 3.0f;
    public AudioClip[] deathSounds;

    private Transform _playerTransform;
    private Rigidbody rb;
    private SpawnHandler spawnHandler;

    private bool awaitingRespawn;
    private float respawnCachedTimer;
    private int cachedAmmo;
    private int cachedHealth;

    private void Start()
    {
        //Used for respawn timer
        awaitingRespawn = false;
        spawnHandler = FindObjectOfType<SpawnHandler>();

        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Random.Range((0 - offsetAmount), (0 + offsetAmount))
            , 0
            , Random.Range((0 - offsetAmount), (0 + offsetAmount)));

        _playerTransform = GameObject.FindGameObjectWithTag("Player").gameObject.transform;
    }
    private void Update()
    {
        //Triggered on death
        if (awaitingRespawn)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer < 0.2f)
            {
                Respawn();
            }
        }
        else
        {
            if (Vector3.Distance(_playerTransform.position, gameObject.transform.localPosition) > 3.5f)
            {
                gameObject.transform.localPosition = Vector3.MoveTowards(
                    gameObject.transform.localPosition,
                    _playerTransform.position,
                    botspeed * Time.deltaTime
                );
            }
            
            //Face player
            rb.gameObject.transform.LookAt(_playerTransform);
        }
    }

    public void HitHandler()
    {
        //Play random death audio
        int randomDeathSoundNum = Random.Range(0, deathSounds.Length);
        AudioSource.PlayClipAtPoint(deathSounds[randomDeathSoundNum], transform.position);

        gameObject.transform.position = new Vector3(0, -3000, 0);
        awaitingRespawn = true;
    }

    private void Respawn()
    {
        //Reset values
        awaitingRespawn = false;

        respawnTimer = respawnCachedTimer;
        gameObject.transform.position = spawnHandler.GetRandomGenericSpawn().transform.position;
    }
}
