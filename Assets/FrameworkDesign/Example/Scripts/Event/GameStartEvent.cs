using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    /// <summary>
    /// ��Ϸ��ʼ�¼�
    /// </summary>
    public static class GameStartEvent
    {

        private static Action mOnGameStartEvent;

        /// <summary>
        /// ע���¼�
        /// </summary>
        /// <param name="onEvent">Ҫע����¼�</param>
        public static void Register(Action onEvent) {
            mOnGameStartEvent += onEvent;
        }

        /// <summary>
        /// ע���¼�
        /// </summary>
        /// <param name="onEvent">Ҫע�����¼�</param>
        public static void UnRegister(Action onEvent) {
            mOnGameStartEvent -= onEvent;
        }

        /// <summary>
        /// �����¼�
        /// </summary>
        public static void Trigger() {
            mOnGameStartEvent?.Invoke();
        }

    }
}


