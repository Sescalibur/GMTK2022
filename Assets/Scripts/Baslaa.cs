using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Baslaa : MonoBehaviour
{
    // Start is called before the first frame update
    //public static Gun gun;
    public GameObject firsPanel;
    public GameObject winPanel;
    public GameObject losePanel;
    void Awake()
    {
		
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  //      win();
		//lose();
    }

    public void tik()
    {
	    SceneManager.LoadScene(1);
    }

    public void again()
    {
	    SceneManager.LoadScene(0);
    }

   // void win()
   // {
	  //  if (gun.deadName!=null && gun.deadName == "Player")
	  //  {
		 //   winPanel.SetActive(true);
	  //  }
   // }

   // void lose()
   // {
	  //  if (gun.deadName != null && gun.deadName == "Enemy")
	  //  {
			//losePanel.SetActive(true);
	  //  }
   // }
}
