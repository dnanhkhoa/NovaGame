using UnityEngine;
using System.Collections;

// Done

public class WalkerMovement : MonoBehaviour
{
    public float speed = 5f;

    public MovementDirection direction;
    ScreenInfo screenInfo;
    System.Random rand = new System.Random();

    // Use this for initialization
    void Start()
    {
        direction = MovementDirection.idle;
        screenInfo = GameInfo.GetScreenInfo();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;

        if (direction == MovementDirection.idle)
        {
            return;
        }
        else if (direction == MovementDirection.left) {
            pos.x -= speed * Time.deltaTime;
        }
        else if (direction == MovementDirection.right) {
            pos.x += speed * Time.deltaTime;
        }
        
        // Update
        gameObject.transform.position = pos;
    }
}
