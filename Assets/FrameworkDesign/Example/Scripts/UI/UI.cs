using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class UI : MonoBehaviour
    {
        GameObject mPassPanel;

        private void Awake() {

            mPassPanel = transform.Find("Canvas/GamePassPanel").gameObject;
            mPassPanel.SetActive(false);
            GamePassEvent.Register(OnGamePass);

        }

        private void OnGamePass() {
            mPassPanel.SetActive(true);
        }

        private void OnDestroy() {
            GamePassEvent.UnRegister(OnGamePass);
        }

    }
}


