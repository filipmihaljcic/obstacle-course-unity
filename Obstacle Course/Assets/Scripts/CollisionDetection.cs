
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts
{
    public class CollisionDetection : MonoBehaviour
    {
        private void OnCollisionEnter([NotNull]Collision _other) 
        {   
            if(_other.gameObject.tag == "Player")
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
    }
}
