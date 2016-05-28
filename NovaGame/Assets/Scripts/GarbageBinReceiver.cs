using UnityEngine;
using System.Collections;

public class GarbageBinReceiver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D trigger) {
        GameObject manager = GameObject.Find("Manager");

        manager.SendMessage("UpdateScore", 1);

        Destroy(trigger.gameObject);
    }
}
