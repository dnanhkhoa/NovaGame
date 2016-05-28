using UnityEngine;
using System.Collections;

public class WalkerMovement : MonoBehaviour
{
    enum MovementDirection
    {
        idle,
        left,
        right
    }

    public float speed = 5f;

    MovementDirection direction;
    ScreenInfo screenInfo;
    System.Random rand = new System.Random();

    // Use this for initialization
    void Start()
    {
        direction = (MovementDirection) 0;
        screenInfo = GameInfo.GetScreenInfo();
    }

    // Update is called once per frame
    void Update()
    {
        // Idle
        if (direction == MovementDirection.idle)
        {
            return;
        }

        Vector3 pos = gameObject.transform.position;
        
        if (pos.x < screenInfo.xLeftMost)
        {
            direction = MovementDirection.right;
        }
        else if (pos.x > screenInfo.xRightMost)
        {
            direction = MovementDirection.left;
        }

        if (direction == MovementDirection.left)
            pos.x -= 1 * Time.deltaTime;
        else if (direction == MovementDirection.right)
            pos.x += 1 * Time.deltaTime;

        gameObject.transform.position = pos;
    }
}
