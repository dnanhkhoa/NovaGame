using UnityEngine;
using System.Collections;

public class GarbageBin : MonoBehaviour {

    private float leftMost;
    private float rightMost;
    private float topMost;
    private float bottomMost;

    // Use this for initialization
    void Start() {
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftTop = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance));
        Vector3 rightBottom = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        leftMost = leftTop.x;
        rightMost = rightBottom.x;
        topMost = leftTop.y;
        bottomMost = rightBottom.y;
    }

    // Update is called once per frame
    void Update() {
        MoveWithMouse();
    }

    private void MoveWithMouse() {
        float gameWidth = rightMost * 2;
        Vector3 paddlePos = new Vector3(0f, this.transform.position.y, transform.position.z);
        float mousePosInBlock = Input.mousePosition.x / Screen.width * gameWidth;
        paddlePos.x = mousePosInBlock - gameWidth / 2;

        this.transform.position = paddlePos;
    }
}
