using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Me.DerangedSenators.CopsAndRobbers
{
    /// <summary>
    /// This Class can control the Debug Textfield on the Round UI to ease debugging over multiple instances
    /// </summary>
    /// @author Hanzalah Ravat
    /**
    public class UIDebug: MonoBehaviour
    {
        string myLog;
        Queue myLogQueue = new Queue();
        public Text TextField;
        void OnEnable () {
            Application.logMessageReceived += HandleLog;
        }
     
        void OnDisable () {
            Application.logMessageReceived -= HandleLog;
        }
 
        
        void HandleLog(string logString, string stackTrace, LogType type){
            myLog = logString;
            string newString = "\n [" + type + "] : " + myLog;
            myLogQueue.Enqueue(newString);
            if (type == LogType.Exception)
            {
                newString = "\n" + stackTrace;
                myLogQueue.Enqueue(newString);
            }
            myLog = string.Empty;
            foreach(string mylog in myLogQueue){
                myLog += mylog;
            }
        }
 
        void OnGUI () {
            GUILayout.Label(myLog);
        }

        private void FixedUpdate()
        {
            TextField.text = myLog;
        }
    }
    */
}