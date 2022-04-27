using JetBrains.Annotations;
using UnityEngine;

namespace Project.Scripts
{
    public class ObjectHit : MonoBehaviour
    {
        private void OnCollisionEnter([NotNull]Collision other) 
        {
            if(other.gameObject.tag == "Player")
            {
                // when we hit something change color
                GetComponent<MeshRenderer>().material.color = Color.red;
                gameObject.tag = "Hit";
            }  
        }
    }
}
