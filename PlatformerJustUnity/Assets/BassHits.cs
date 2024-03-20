using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BassHits : MonoBehaviour
{

    public AudioSource source;
    public AudioMixer myMixer;



    public AudioClip[] bassSoundz;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBass()
    {
        int bass = Random.Range(0, bassSoundz.Length);
        float pitch = Random.Range(0.6f, 1.4f);
        myMixer.SetFloat("BassPitch", pitch);
        source.clip = bassSoundz[bass];
        source.Play();
    }
}
