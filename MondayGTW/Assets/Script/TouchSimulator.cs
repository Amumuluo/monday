using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GTWEditor
{
    /// <summary>
    /// 主要用于debug，在PC上模拟一些基本的触控事件
    /// </summary>
    public static class TouchSimulator
    {
        static bool[] IsMouseDown = { false, false };

        public static Touch GetTouch(int v)
        {
            if (touches.Length > v) {
                return touches[v];
            }
            else
            {
                Debug.LogError("所求的触控点不存在！");
                return new Touch();
            }
        }

        public static int touchCount
        {
            get
            {
#if UNITY_EDITOR
                return IsMouseDown[swapIndex] ? 1 : 0;
#else
                return Input.touchCount;
#endif
            }
        }
        //
        // Summary:
        //     ///
        //     Returns list of objects representing status of all touches during last frame.
        //     (Read Only) (Allocates temporary variables).
        //     ///
        public static Touch[] touches
        {
            get
            {
#if UNITY_EDITOR
                return GenerateTouchWithMouse();
#else
                return Input.touches;
#endif
            }
        }

        private static Touch[] GenerateTouchWithMouse()
        {
            if (IsMouseDown[swapIndex])
            {
                var rlt = new Touch[1];
                rlt[0] = new Touch();
                rlt[0].position = mousePos[swapIndex];
                rlt[0].deltaPosition = mouseDeltaPos;
                return rlt;
            }
            return new Touch[0];
        }
        static Vector2[] mousePos = { new Vector2(), new Vector2() };
        static Vector2 mouseDeltaPos = new Vector2();
        static int swapIndex = 0;
        public static void Update()
        {
#if UNITY_EDITOR
            int noSwapIndex = swapIndex;
            swapIndex = swapIndex > 0 ? 0 : 1;
            if (Input.GetMouseButton(0))
            {
                IsMouseDown[swapIndex] = true;
                mousePos[swapIndex].x = Input.mousePosition.x;
                mousePos[swapIndex].y = Input.mousePosition.y;
                if (IsMouseDown[noSwapIndex])
                {
                    mouseDeltaPos.x = mousePos[swapIndex].x - mousePos[noSwapIndex].x;
                    mouseDeltaPos.y = mousePos[swapIndex].y - mousePos[noSwapIndex].y;
                }
                else
                {
                    mouseDeltaPos.x = 0;
                    mouseDeltaPos.y = 0;
                }
            }
            else
            {
                IsMouseDown[swapIndex] = false;
            }
#endif
        }
    }
}
