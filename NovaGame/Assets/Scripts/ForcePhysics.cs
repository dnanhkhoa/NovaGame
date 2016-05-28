using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class MyVelocity
    {
        public Vector2 a; // accelerate
        public float x, y;

        public MyVelocity(float x, float y, Vector2 a = new Vector2())
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }

        public void Update()
        {
            x += a.x;
            y += a.y;
        }

        public Vector2 getValue()
        {
            Vector2 result = new Vector2(x, y);
            return result;
        }
    }

    class MyForcePhysics
    {
        List<MyVelocity> velList = new List<MyVelocity>();

        public void Update()
        {
            foreach (MyVelocity vel in velList)
            {
                vel.Update();
            }
        }

        public Vector2 TotalVelocity()
        {
            Vector2 ret = new Vector2();

            foreach (MyVelocity vel in velList)
            {
                ret += vel.getValue();
            }

            return ret;
        }

        public void PushNewVelocity(MyVelocity vel)
        {
            velList.Add(vel);
        }
    }
}
