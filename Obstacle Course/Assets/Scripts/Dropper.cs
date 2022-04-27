using UnityEngine;

namespace Project.Scripts
{
    public class Dropper : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;
        private Rigidbody _rigidBody;
        public float _timeToWait = 5f; // wait time for rock to fall

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            _rigidBody = GetComponent<Rigidbody>();

            _meshRenderer.enabled = false;
            _rigidBody.useGravity = false;
        }

   
        private void Update()
        {
            if(Time.time > _timeToWait)
            {
                // rock drops onto platform
                _meshRenderer.enabled = true;
                _rigidBody.useGravity = true;
            }
        }
    }
}
