using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GarbageSpawner : MonoBehaviour
{
    public float deltaSpwanRate = 3;
	public List<GameObject> GarbageList;

	float nextSpawnTime = 0;
    float throwSpeed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int time = (int)Time.time;

		if (time > nextSpawnTime)
		{
            nextSpawnTime += deltaSpwanRate;

			GameObject garbage = getRandomGarbage();
            GameObject clone = Instantiate(garbage, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.transform.position.x, -throwSpeed);
		}
	}

	GameObject getRandomGarbage()
	{
		System.Random ra = new System.Random();
		int index = ra.Next(GarbageList.Count);

		if (index >= 0)
		{
			return GarbageList[index];
		}

		return null;
	}
}
