using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GTWEditor
{
    static class ResolutionMgr
    {
        public static uint TargetWidth { get { return targetWidth; } }
        public static uint TargetHeight { get { return targetHeight; } }
        public static int RealWidth { get { return Screen.width; } }
        public static int RealHeight { get { return Screen.height; } }
        private static uint targetWidth;
        private static uint targetHeight;
        public static void SetResolution(uint width,uint height,bool fullScreen,uint fps)
        {
            targetWidth = width;
            targetHeight = height;
            Screen.SetResolution(Convert.ToInt32(targetWidth), Convert.ToInt32(targetHeight), fullScreen, Convert.ToInt32(fps));
            GTWConsole.Log("[ResolutionMgr.SetResolution()]");
            GTWConsole.Log("TargetWidth: " + targetWidth);
            GTWConsole.Log("TargetHeight: " + targetHeight);
            GTWConsole.Log("RealWidth: " + RealWidth);
            GTWConsole.Log("RealHeight: " + RealHeight);
            GTWConsole.Log("[ResolutionMgr.SetResolution()]");
        }
    }
}
