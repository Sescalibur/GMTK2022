using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimeLineControl : MonoBehaviour
{
	public PlayableDirector director;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetButtonDown("Fire1"))
	    {
			play();
	    }
    }

    public void play()
    {
		director.Play();
    }

    public void stop()
    {
		director.Stop();
    }
}
