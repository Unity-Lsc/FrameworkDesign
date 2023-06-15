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
            //��ȡ��ǰ�������еĸ��ڵ�
            //var objs = SceneManager.GetActiveScene().GetRootGameObjects();
            //foreach (var obj in objs) {
            //    Debug.Log(obj.name);
            //}
        }

    }

}


