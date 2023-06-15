using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    /// <summary>
    /// 游戏开始事件
    /// </summary>
    public static class GameStartEvent
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


