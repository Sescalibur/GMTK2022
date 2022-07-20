using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class Gun : MonoBehaviour
{
	private float range = 10f;
	public float impactForce = 3000f;
	public GameObject firePos;
	private bool win = false;
	private bool lose = false;
	private int random;
	public Transform target;
	public ParticleSystem muzzle;
	public GameObject impactEffect;
	public PuppetMaster puppet;
	public TimeLineControl Control;
	public Baslaa basla;

	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    random = Random.Range(0, 6);
	    if (win)
	    {
		    basla.winPanel.SetActive(true);
	    }
	    if (lose)
	    {
		    basla.losePanel.SetActive(true);
	    }
    }

    public void Shoot()
    {
	    if (random == 0)
	    {
		    muzzle.Play();
		    RaycastHit hit;
		    if (Physics.SphereCast(firePos.transform.position, 0.5f, target.transform.position-firePos.transform.position, out hit, range))
		    {
			    Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
		    }

		    if (hit.rigidbody != null)
		    {
			    puppet.state = PuppetMaster.State.Dead;
			    hit.rigidbody.AddForce(-hit.normal * impactForce, ForceMode.VelocityChange);
		    }
		    FindObjectOfType<AudioManager>().Play("GunFire");
			Control.stop();
			if (hit.transform.tag == "Player")
			{
				lose = true;
			}

			if (hit.transform.tag == "Enemy")
			{
				win = true;
			}
		}
	    else
	    {
		    FindObjectOfType<AudioManager>().Play("Tetik");
		}
			
    }
}
