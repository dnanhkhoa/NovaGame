using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;

public class GarbageSpawner : MonoBehaviour
{
    public float deltaSpwanRate = 3;
	public List<GameObject> GarbageList;

	float nextSpawnTime = 0;
    Animator animator;

    delegate MyForcePhysics ForceCreatetionFunc();
    List<ForceCreatetionFunc> forceCreationFuncList = new List<ForceCreatetionFunc>();

    System.Random ra = new System.Random();

	// Use this for initialization
	void Start () {
        forceCreationFuncList.Add(CreateForcePhysicsType1);
        forceCreationFuncList.Add(CreateForcePhysicsType2);
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		int time = (int)Time.time;

		if (time > nextSpawnTime)
		{
            nextSpawnTime += deltaSpwanRate;

			GameObject garbage = getRandomGarbage();
            GameObject clone = Instantiate(garbage, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
            //clone.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.transform.position.x-10f, -4f);
            clone.SendMessage("SetForceValue", CreateForcePhysics());
            //Debug.Log(clone.transform.position.z);
            //Trust debug

            animator.Play("LeftThrowing");
        }
	}


    MyForcePhysics CreateForcePhysics()
    {
        int index = ra.Next(forceCreationFuncList.Count);
        return forceCreationFuncList[index]();
    }


    MyForcePhysics CreateForcePhysicsType1()
    {
        MyForcePhysics f = new MyForcePhysics();
        MyVelocity vel = null;

        float deltaTime = Time.deltaTime;
        Vector3 objPos = gameObject.transform.position;

        vel = new MyVelocity(3f * deltaTime, -6f * deltaTime);
        if (objPos.x < 0)
            vel.x = -vel.x;

        f.PushNewVelocity(vel);

        return f;
    }

    MyForcePhysics CreateForcePhysicsType2()
    {
        MyForcePhysics f = new MyForcePhysics();
        MyVelocity vel = null;

        float deltaTime = Time.deltaTime;
        Vector3 objPos = gameObject.transform.position;

        vel = new MyVelocity(0, 0, new Vector2(0, -0.2f * deltaTime));
        f.PushNewVelocity(vel);

        vel = new MyVelocity(3f * deltaTime, 3f * deltaTime);
        if (objPos.x >= 0)
            vel.x = -vel.x;

        f.PushNewVelocity(vel);

        return f;
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
