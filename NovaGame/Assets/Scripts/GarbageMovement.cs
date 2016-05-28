using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class GarbageMovement : MonoBehaviour {

    MyForcePhysics forcePhysics = new MyForcePhysics();

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        forcePhysics.Update();

        Vector3 pos = gameObject.transform.position;
        Vector2 totalVelocity = forcePhysics.TotalVelocity();

        pos.x += totalVelocity.x;
        pos.y += totalVelocity.y;

        gameObject.transform.position = pos;
	}

    void SetForceValue(MyForcePhysics forcePhy)
    {
        forcePhysics = forcePhy;
    }
}
