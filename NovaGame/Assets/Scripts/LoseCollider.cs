using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    void Start() {
        
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        //Debug.Log("Lose" + trigger.name);
		GameObject managerObject = GameObject.Find("Manager");
		managerObject.SendMessage("InvokeGameOver");
    }
}
