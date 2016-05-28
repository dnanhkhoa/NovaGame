using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[System.Serializable]
struct ScreenInfo
{
    public float xLeftMost, xRightMost;
    public float yTopMost, yBottomMost;
    public float width, height;
}

class GameInfo
{
    public static ScreenInfo GetScreenInfo()
    {
        ScreenInfo info = new ScreenInfo();

        float distance = Camera.main.transform.position.z;
        Vector3 leftTop = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, -distance));
        Vector3 rightBottom = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, -distance));

        info.xLeftMost = leftTop.x;
        info.xRightMost = rightBottom.x;
        info.width = info.xRightMost - info.xLeftMost;

        info.yTopMost = leftTop.y;
        info.yBottomMost = rightBottom.y;
        info.height = info.yTopMost - info.yBottomMost;

        return info;
    }
}
