using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GTWEditor
{
    public static class GTWConsole
    {
        public static bool IsOpen = true;
        public static Rect LabelSpace = new Rect(0, 0, 360, 640);
        static Rect realLabelSpace = new Rect(0, 0, 360, 640);
        static Vector2 ScrollPosition = new Vector2();
        static string textContent = "";
        static int MsgCount = 0;

        static GUIStyle FontStyle;
        static List<string> ConsoleContent = new List<string>();

        public static void Awake()
        {
        }

        public static void Log(object msg)
        {
            var arr = msg.ToString().Split('\n');
            for(int i = 0; i < arr.Length; i++)
            {
                ConsoleContent.Add(arr[i]);
                MsgCount++;
            }
            Debug.Log(msg);
        }

        public static void Warning(object msg)
        {
            var arr = msg.ToString().Split('\n');
            ConsoleContent.Add(">>>>WARNING_START<<<<");
            for (int i = 0; i < arr.Length; i++)
            {
                ConsoleContent.Add(arr[i]);
                MsgCount++;
            }
            ConsoleContent.Add(">>>>WARNING__END_<<<<");
            Debug.LogWarning(msg);
        }

        public static void Update()
        {
            int cnt = ConsoleContent.Count;
            for(int i = 0; i < cnt; i++)
            {
                textContent += "\n" + ConsoleContent[i].ToString();
            }
            ConsoleContent.Clear();
            if (IsOpen)
            {
                if (null == FontStyle)
                {
                    FontStyle = GUI.skin.label;
                    Log("OriFontSize: " + FontStyle.fontSize);
                    FontStyle.fontSize = 20;
                    Log("FontSize: " + FontStyle.fontSize);
                }
                var content = new GUIContent(textContent);
                realLabelSpace.height = FontStyle.CalcHeight(content, realLabelSpace.width);
                ScrollPosition = GUI.BeginScrollView(LabelSpace, ScrollPosition, realLabelSpace);
                GUI.Label(realLabelSpace, content, FontStyle);
                GUI.EndScrollView();
            }
        }
    }
}
