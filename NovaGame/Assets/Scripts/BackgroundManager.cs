using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class BackgroundManager : MonoBehaviour {

    public List<Sprite> spriteList = new List<Sprite>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*
        float t = Time.time;

        if (t > nextTime)
        {
            nextTime += 5;

            currentIndex = (currentIndex + 1) % spriteList.Count;

            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = spriteList[currentIndex];
        }
        */
	}
}
