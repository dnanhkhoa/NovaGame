using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPlay() {
        LevelManager levelManager = new LevelManager();
        levelManager.LoadLevel("Game");
    }
}
