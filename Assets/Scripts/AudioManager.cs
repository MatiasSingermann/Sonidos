using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
    bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isPlaying)
            {
                source.Play();
            }
            else
            {
                source.Stop();
            }
            isPlaying = !isPlaying;
        }
    }
}
