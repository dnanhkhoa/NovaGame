using UnityEngine;
using System.Collections;

// Done

public class WalkerMovement : MonoBehaviour
{
    public float speed = 5f;

    public MovementDirection direction;

	public float idleTime = 0;
	float idleTimeout = 0;

    ScreenInfo screenInfo;
    System.Random ra = new System.Random();


    // Use this for initialization
    void Start()
    {
        screenInfo = GameInfo.GetScreenInfo();

		direction = MovementDirection.idle;
    }

    // Update is called once per frame
    void Update()
    {
		if (direction == MovementDirection.idleForever)
		{
			return;
		}


		Vector3 pos = gameObject.transform.position;

		// temporary code to make walker walking

		if (pos.x > screenInfo.xRightMost)
			direction = MovementDirection.left;
		else if (pos.x < screenInfo.xLeftMost)
			direction = MovementDirection.right;

		//----------------------------
        

        if (direction == MovementDirection.idle)
        {
			UpdateIdleState();
        }

        if (direction == MovementDirection.left) {
            pos.x -= speed * Time.deltaTime;
        }
        else if (direction == MovementDirection.right) {
            pos.x += speed * Time.deltaTime;
        }
        
        // Update
        gameObject.transform.position = pos;
    }


	void SetIdle()
	{
		float currentTime = Time.time;
		idleTimeout = currentTime + idleTime;
		direction = MovementDirection.idle;
	}

	void SetIdleForever(Vector3 position)
	{
		gameObject.transform.position = position;
		direction = MovementDirection.idleForever;
	}


	void UpdateIdleState()
	{
		// post some statement

		float currentTime = idleTimeout - Time.time;

		if (currentTime <= 0)
		{
			idleTimeout = 0;
			int choose = ra.Next(2);

			if (choose == 0)
				direction = MovementDirection.left;
			else
				direction = MovementDirection.right;
		}
	}

    void OnCollisionEnter2D(Collision2D collision) {
        print("Collision");
    }
}
