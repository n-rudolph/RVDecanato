using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Room : MonoBehaviour {


    

    [SerializeField]
    internal Text roomName;

    
    void OnTriggerEnter(Collider other)
    {     
        roomName.gameObject.SetActive(true);

    }

   
    void OnTriggerExit(Collider other)
    {
       
        roomName.gameObject.SetActive(false);

    }
    



    // Use this for initialization
    void Start () {
        roomName.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
