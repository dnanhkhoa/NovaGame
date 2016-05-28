using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkerManager : MonoBehaviour {

	public List<GameObject> walkerList = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void DoIdleWalker(GameObject walker)
	{
		int walkerIndex = walkerList.FindIndex(x => x == walker);

		walker.SendMessage("DoIdle");
	}
}
