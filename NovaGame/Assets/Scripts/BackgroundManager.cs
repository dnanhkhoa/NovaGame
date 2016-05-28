using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class BackgroundManager : MonoBehaviour {

    public Sprite[] backgrounds;
    System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
        (GetComponent<Renderer>() as SpriteRenderer).sprite = backgrounds[rand.Next(backgrounds.Length)];
	}
	
	// Update is called once per frame
	void Update () {
	}
}
