using UnityEngine;
using System.Collections.Generic;

public class Laboratory : Room {

    [SerializeField]
    private List<Rigidbody> spheres;
    
    // Use this for initialization
	
    void Start () {
        roomName.text = "Laboratorio de Informática";
        roomName.gameObject.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < spheres.Count; i++)
            {
                spheres[i].useGravity = true;
            }
        }

        roomName.gameObject.SetActive(true);

    }

   

    void OnTriggerExit(Collider other)
    {

        roomName.gameObject.SetActive(false);

    }
}
