using UnityEngine;
using System.Collections;

public class WalkerMovement : MonoBehaviour
{

    enum MovementDirection
    {
        left,
        right
    }

    public float moveDelta;

    MovementDirection direction;
    ScreenInfo screenInfo;

	// Use this for initialization
	void Start () {
        direction = (MovementDirection) UnityEngine.Random.Range(0, System.Enum.GetNames(typeof(MovementDirection)).Length);
        screenInfo = GameInfo.GetScreenInfo();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = gameObject.transform.position;
        if (pos.x < screenInfo.xLeftMost)
            direction = MovementDirection.right;
        else if (pos.x > screenInfo.xRightMost)
            direction = MovementDirection.left;
        if (direction == MovementDirection.left)
            pos.x -= moveDelta * Time.deltaTime;
        else if (direction == MovementDirection.right)
            pos.x += moveDelta * Time.deltaTime;

        gameObject.transform.position = pos;
	}
}
