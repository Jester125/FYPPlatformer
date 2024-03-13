using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public GameObject midObj;
    public GameObject highObj;

    public AudioSource midSource;
    public AudioSource highSource;


    public AudioClip[] highSoundz;
    public AudioClip[] midSoundz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == NewPlayer.Instance.gameObject)
        {
            
            int high = Random.Range(0, highSoundz.Length);
            int mid = Random.Range(0, midSoundz.Length);
            if (!midSource.isPlaying)
            {
                midSource.clip = midSoundz[mid];
                midSource.Play();
            }
            
            if (!highSource.isPlaying)
            {
                highSource.clip = highSoundz[high];
                highSource.Play();
            }
            
        }

    }
}
