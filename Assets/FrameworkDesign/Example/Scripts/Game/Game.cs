using UnityEngine;

namespace FrameworkDesign.Example
{

    public class Game : MonoBehaviour
    {
        GameObject mEnemies;

        private void Awake() {
            mEnemies = transform.Find("Enemies").gameObject;
            mEnemies.SetActive(false);
            GameStartEvent.Register(OnGameStart);
        }

        private void OnGameStart() {
            transform.Find("Enemies").gameObject.SetActive(true);
        }

        private void OnDestroy() {
            GameStartEvent.UnRegister(OnGameStart);
        }

    }

}


