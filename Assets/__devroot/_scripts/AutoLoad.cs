using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoad : MonoBehaviour
{
    private static bool hasLoaded = false;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (!hasLoaded)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            hasLoaded = true;
        }
    }
}
