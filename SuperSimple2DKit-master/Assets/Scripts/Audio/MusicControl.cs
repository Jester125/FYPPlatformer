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




    FMOD.Studio.EventInstance FoleyEv;
    FMOD.Studio.EventInstance AmbientEv;
    FMOD.Studio.EventInstance RunEv;
    FMOD.Studio.EventInstance BreaksEv;

    // Start is called before the first frame update
    void Start()
    {
        //FoleyEv.EventReference = FMODUnity.RuntimeManager.PathToEventReference(foley);
        FoleyEv = FMODUnity.RuntimeManager.CreateInstance(foley);
        AmbientEv = FMODUnity.RuntimeManager.CreateInstance(ambient);
        RunEv = FMODUnity.RuntimeManager.CreateInstance(run);
        BreaksEv = FMODUnity.RuntimeManager.CreateInstance(breaks);

        FoleyEv.start();
        AmbientEv.start();
        RunEv.start();
        BreaksEv.start();
    }

    public void RestartEvents ()
    {
        Debug.Log("Release");
        FoleyEv.release();
        AmbientEv.release();
        RunEv.release();
        BreaksEv.release();
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
