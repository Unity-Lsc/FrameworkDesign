using UnityEngine;
using UnityEngine.SceneManagement;

namespace FrameworkDesign.Example
{

    public class Enemy : MonoBehaviour
    {
        static int mKilledEnemyCount = 0;

        private void OnMouseDown() {
            
            mKilledEnemyCount++;
            Destroy(gameObject);
            if(mKilledEnemyCount >= 10) {
                GamePassEvent.Trigger();
            }
            
        }

        private void Start() {
            //获取当前场景所有的根节点
            //var objs = SceneManager.GetActiveScene().GetRootGameObjects();
            //foreach (var obj in objs) {
            //    Debug.Log(obj.name);
            //}
        }

    }

}


