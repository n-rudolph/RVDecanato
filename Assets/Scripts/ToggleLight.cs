using UnityEngine;
using System.Collections.Generic;

public class ToggleLight : MonoBehaviour {

    [SerializeField]
    private List<Light> lights;
    [SerializeField]
    private float intensity;


    private bool isOn;

    private bool canToggle;

    void Start()
    {
        isOn = false;
    }

    void Update()
    {
        if (canToggle)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inteistyUp();
            }
            else if(Input.GetKeyDown(KeyCode.Q)){
                inteistyDown();
            }
          
        }

    }


    void OnTriggerEnter(Collider other)
    {
        canToggle = true;
    }

    void OnTriggerExit(Collider other)
    {
        canToggle = false;
    }


    private void inteistyUp()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            if (lights[i].intensity <= 2.75f)
                lights[i].intensity+=0.25f ;
        }
    }

    private void inteistyDown()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            if (lights[i].intensity >= 0.25f)
                lights[i].intensity -= 0.25f;
        }

    }
}
