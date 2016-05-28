using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	static LevelManager levelManager = new LevelManager();
	public static ScoreManager ScoreManager;

	ThrawerManager thrawerManager = new ThrawerManager();
	WalkerManager walkerManager = new WalkerManager();
	

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void SetIdleWalker(GameObject walker)
	{
		walkerManager.SetIdleWalker(walker);
	}

	void SetIdleWalkerForever(GameObject walker, Vector3 position)
	{
		walkerManager.SetIdleForever(walker, position);
	}

	
	public void InvokeGameOver()
	{
		levelManager.LoadLevel("Lose");
	}
}
