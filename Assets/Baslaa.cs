using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baslaa : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
		Time.timeScale = 0f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tik()
    {
	    Time.timeScale = 1f;
	    Destroy(gameObject);
    }
}
