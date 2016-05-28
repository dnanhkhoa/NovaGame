using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	ThrawerManager thrawerManager = new ThrawerManager();
	WalkerManager walkerManager = new WalkerManager();

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void DoIdleWalker(GameObject walker)
	{
		walkerManager.DoIdleWalker(walker);
	}
}
