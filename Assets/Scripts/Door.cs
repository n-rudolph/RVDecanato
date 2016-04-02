using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    private bool canToggle;
    private bool isOpen;


    [SerializeField]
    private GameObject axis;

    [SerializeField]
    private GameObject door;
	// Use this for initialization
	void Start () {
        canToggle = false;
        isOpen = false;
	}
	
	// Update is called once per frame
    void Update() {
        if(canToggle && Input.GetKeyDown(KeyCode.E)){
            if(isOpen){
                closeDoor();
            }
            else {
                openDoor();
            }
        }
        
    }

private void openDoor()
{
    isOpen = true;
    Vector3 axisPosition = axis.transform.position;

    door.transform.RotateAround(axisPosition, Vector3.up, 90);
}

private void closeDoor()
{
    isOpen = false;
 	Vector3 axisPosition = axis.transform.position;
    door.transform.RotateAround(axisPosition, Vector3.up, -90);
}

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            canToggle = true;
        }
    }
    
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.tag == "Player"){
            canToggle = false;
        }
    }
  
 
}
