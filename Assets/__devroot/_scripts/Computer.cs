using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Computer : MonoBehaviour
{
    public GameObject[] screens;

    private bool on = true;
    private VideoPlayer videoPlayer;
    private MeshRenderer meshRenderer;
    private Material material;
    private Material videoMaterial = null;
    private List<PlayVideo> videos = new List<PlayVideo>();

    private void Start()
    {
        foreach (var go in screens)
        {
            videos.Add(go.GetComponent<PlayVideo>());
        }
    }

    public void TogglePC()
    {
        foreach (var vid in videos)
        {
            if (on)
            {
                meshRenderer = vid.GetComponent<MeshRenderer>();
                material = meshRenderer.material;
                videoMaterial = new Material(Shader.Find("Universal Render Pipeline/Unlit"));
                videoMaterial.color = Color.white;

                meshRenderer.material = videoMaterial;
                videoPlayer = vid.GetComponent<VideoPlayer>();
                videoPlayer.clip = vid.videoClips[0];
                videoPlayer.Play();
                StartCoroutine(PlayNextClip(vid));
            }
            else
            {
                vid.Stop();
            }
                
        }
        on = !on;
    }

    IEnumerator PlayNextClip(PlayVideo vid)
    {
        yield return new WaitForSeconds(5.0f);

        meshRenderer.material = videoMaterial;
        videoPlayer = vid.GetComponent<VideoPlayer>();
        videoPlayer.clip = vid.videoClips[1];
        videoPlayer.Play();
    }
}
