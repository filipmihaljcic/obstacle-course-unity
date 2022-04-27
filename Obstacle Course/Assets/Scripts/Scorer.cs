using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    private int _hits = 0;

    private void OnCollisionEnter([NotNull]Collision _other) 
    {
        if(_other.gameObject.tag != "Hit")
        {
            _hits++;

            if (_hits == 3)
                SceneManager.LoadScene("Level1", LoadSceneMode.Single);
       }
   } 
}
