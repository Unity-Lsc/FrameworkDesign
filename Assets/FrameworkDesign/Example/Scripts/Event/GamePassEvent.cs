using System;
using UnityEngine;

namespace FrameworkDesign.Example
{
    /// <summary>
    /// ��Ϸͨ���¼�
    /// </summary>
    public class GamePassEvent : MonoBehaviour
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


