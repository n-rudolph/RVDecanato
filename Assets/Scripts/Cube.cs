using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    private IList list = new ArrayList() { Color.blue, Color.cyan, Color.green, Color.grey, Color.magenta,Color.yellow, Color.red };
    private int index = 0;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.black;
       
    }  
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player"){
            gameObject.GetComponent<Renderer>().material.color = (Color)list[Random.Range(0, list.Count)];         
        }  
    }
}
