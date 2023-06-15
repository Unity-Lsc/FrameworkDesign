using System;
using UnityEngine;

namespace FrameworkDesign.Example
{
    /// <summary>
    /// 游戏通关事件
    /// </summary>
    public class GamePassEvent : MonoBehaviour
    {
        private static Action mOnGameStartEvent;

        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="onEvent">要注册的事件</param>
        public static void Register(Action onEvent) {
            mOnGameStartEvent += onEvent;
        }

        /// <summary>
        /// 注销事件
        /// </summary>
        /// <param name="onEvent">要注销的事件</param>
        public static void UnRegister(Action onEvent) {
            mOnGameStartEvent -= onEvent;
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        public static void Trigger() {
            mOnGameStartEvent?.Invoke();
        }
    }
}


