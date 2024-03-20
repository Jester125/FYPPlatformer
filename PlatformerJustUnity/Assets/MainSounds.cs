using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSounds : MonoBehaviour
{
    public AudioSource source;
    

    public AudioClip[] mainSoundz;
    

    float minPossibleWait = 15f;
    float maxPossibleWait = 30f;
    bool playSound = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playSound)
        {
            StartCoroutine("YieldForRandomDuration"); 
        }
    }

    IEnumerator YieldForRandomDuration()
    {
        playSound = false; // this stops the function being called while its running
        float dur = Random.Range(minPossibleWait, maxPossibleWait); // choose a random time to play the sound
        yield return new WaitForSeconds(dur); // wait that duration
        int main = Random.Range(0, mainSoundz.Length); // choose random clip      
        source.clip = mainSoundz[main]; // set clip
        source.Play(); // play
        playSound = true; // function is ready to be called again in the next update
    }
}
