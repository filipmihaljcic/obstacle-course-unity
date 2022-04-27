using UnityEngine;

namespace Project.Scripts
{
    public class Spinner : MonoBehaviour
    {
        public float _xAngle = 0;
        public float _yAngle = 0;
        public float _zAngle = 0;

        private void Update()
        {
            // make object spin around desired axis
            transform.Rotate(_xAngle, _yAngle, _zAngle);   
        }
    }
}
