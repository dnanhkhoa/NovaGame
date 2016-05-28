using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    ScreenInfo screenInfo;

	// Use this for initialization
	void Start () {
        screenInfo = GameInfo.GetScreenInfo();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
