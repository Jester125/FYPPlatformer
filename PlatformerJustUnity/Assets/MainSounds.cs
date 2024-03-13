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
        playSound = false;
        float dur = Random.Range(minPossibleWait, maxPossibleWait);
        yield return new WaitForSeconds(dur);
        int main = Random.Range(0, mainSoundz.Length);       
        source.clip = mainSoundz[main];
        source.Play();
        playSound = true;
    }
}
