using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Basic bot wandering code
//This can get pretty crazy
public class BotController : MonoBehaviour
{
    public float offsetAmount = 3.0f;
    public int waitForNewDestination = 10;
    public float jumpForce = 400.0f;

    private SpawnHandler spawnHandler;
    private Rigidbody rb;
    private Transform _playerTransform;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        spawnHandler = GameObject.FindGameObjectWithTag("SP_SpawnHandler").GetComponent<SpawnHandler>();
        rb.AddForce(Random.Range((0 - offsetAmount), (0 + offsetAmount))
            , 0
            , Random.Range((0 - offsetAmount), (0 + offsetAmount)));

        _playerTransform = null; // GameObject.FindObjectOfType<PlayerStats>().gameObject.transform;
    }
    private void Update()
    {
        gameObject.transform.localPosition = Vector3.MoveTowards(
            gameObject.transform.localPosition,
            _playerTransform.localPosition,
            5.0f * Time.deltaTime
        );

        //Face player
        rb.gameObject.transform.LookAt(_playerTransform);
    }

    private Vector3 DestinationOffset(Vector3 sd)
    {
        //Gets a randomish destination
        return new Vector3(
            Random.Range((sd.x - offsetAmount), (sd.x + offsetAmount))
            , sd.y
            , Random.Range((sd.z - offsetAmount), (sd.z + offsetAmount))
            );
    }
}
