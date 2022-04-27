using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts
{
    public class GameLoader : MonoBehaviour
    {
        public void LoadLevel()
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
