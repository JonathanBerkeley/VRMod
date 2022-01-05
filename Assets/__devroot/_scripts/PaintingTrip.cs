using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingTrip : MonoBehaviour
{
    public GameObject[] paintings;
    public float time = 0.5f;

    void Start()
    {
        PlacePainting();
    }

    private void PlacePainting()
    {
        GameObject painting = Instantiate(
            paintings[Random.Range(0, paintings.Length)], 
            gameObject.transform.position, 
            gameObject.transform.rotation
        );
        StartCoroutine("WaitRefresh", painting);
    }

    private IEnumerator WaitRefresh(GameObject painting)
    {
        yield return new WaitForSeconds(time);
        Destroy(painting);
        PlacePainting();
    }
}
