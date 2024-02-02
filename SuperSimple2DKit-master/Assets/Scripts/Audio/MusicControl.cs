using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{

    //[FMODUnity.EventRef]
    //FMODUnity.EventReference;
    public string foley = "event:/Foley/FoleySounds";
    public string ambient = "event:/Ambient/Ambient";
    public string run = "event:/Running/Run";
    public string breaks = "event:/Breaks/Breaks";
    //public string main = "event:/Main/Main";




    FMOD.Studio.EventInstance FoleyEv;
    FMOD.Studio.EventInstance AmbientEv;
    FMOD.Studio.EventInstance RunEv;
    FMOD.Studio.EventInstance BreaksEv;
    //FMOD.Studio.EventInstance MainEv;

    // Start is called before the first frame update
    void Start()
    {
        //FoleyEv.EventReference = FMODUnity.RuntimeManager.PathToEventReference(foley);
        FoleyEv = FMODUnity.RuntimeManager.CreateInstance(foley);
        AmbientEv = FMODUnity.RuntimeManager.CreateInstance(ambient);
        RunEv = FMODUnity.RuntimeManager.CreateInstance(run);
        BreaksEv = FMODUnity.RuntimeManager.CreateInstance(breaks);
        //MainEv = FMODUnity.RuntimeManager.CreateInstance(main);

        FoleyEv.start();
        AmbientEv.start();
        RunEv.start();
        BreaksEv.start();
        //MainEv.start();
    }

    public void RestartEvents ()
    {
        Debug.Log("Release");
        FoleyEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        AmbientEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        RunEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        BreaksEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        //MainEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        FMODUnity.RuntimeManager.PlayOneShot("event:/Ending");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
