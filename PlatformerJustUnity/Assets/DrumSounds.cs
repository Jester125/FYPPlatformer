using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

public class DrumSounds : MonoBehaviour
{

    
    public AudioClip[] fillClips; // all 7 possible fills
    public AudioSource[] fillSources = new AudioSource[2]; // the two different fill players
    public AudioSource[] runningSources = new AudioSource[2]; //other breaks 
    public AudioSource[] mainBreakSources = new AudioSource[2];
    public AudioSource[] combatBreakSources = new AudioSource[2];
    [SerializeField] private AudioMixer myMixer;
    



    public float bpm = 87.0f;
    public int beatsPerSegment = 4; // aka 1 bar
    private double nextEventTime;
    private bool running = false;
    private float interval = 2.759f; // the length of 1 bar at 87bpm
    private int fill;
    private int flip = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextEventTime = AudioSettings.dspTime + 4f;
        running = true;
        myMixer.SetFloat("PlayFill", -80f);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!running)
        {
            return;
        }

        double time = AudioSettings.dspTime;

        if (time + 1f > nextEventTime)
        {
            //we are now 1 sec away from playing the sound so we prepare now to make sure it plays on time

            fill = Random.Range(0, fillClips.Length); //randomise the next fill clip
            fillSources[flip].clip = fillClips[fill]; // set the clip
            fillSources[flip].PlayScheduled(nextEventTime); // play fill
            runningSources[flip].PlayScheduled(nextEventTime); // play break
            mainBreakSources[flip].PlayScheduled(nextEventTime); // break 2
            combatBreakSources[flip].PlayScheduled(nextEventTime); // combat 
            nextEventTime += 60.0f / bpm * beatsPerSegment; // set next schedule time
            Debug.Log("Scheduled fill to start at time " + nextEventTime);

            flip = 1 - flip; // switch to other audio source
        }

    }

    public void PlayCombat()
    {
        combatBreakSources[0].volume = 0.5f;
        combatBreakSources[1].volume = 0.5f;
    }

    public void StopCombat()
    {
        combatBreakSources[0].volume = 0f;
        combatBreakSources[1].volume = 0f;

    }

    public void PlayFill()
    {
        StartCoroutine("FillTime");
    }

    public IEnumerator FillTime()
    {
        myMixer.SetFloat("PlayFill", -6);
        yield return new WaitForSeconds((global::System.Single)(nextEventTime - AudioSettings.dspTime));
        myMixer.SetFloat("PlayFill", -80f);
    }
}
