using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkerManager
{

	public List<GameObject> walkerList = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void SetIdleWalker(GameObject walker)
	{
		int walkerIndex = walkerList.FindIndex(x => x == walker);
		walker.SendMessage("SetIdle");
	}


	public void SetIdleForever(GameObject walker, Vector3 position)
	{
		int walkerIndex = walkerList.FindIndex(x => x == walker);
		walker.SendMessage("SetIdleForever", position);
	}
}
