using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Scripts
{
    public class Mover : MonoBehaviour
    {
        [Tooltip("Moving speed of our player.")]
        public float _moveSpeed = 10f;
    
        private void Update()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            float _xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
            float _zValue = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;
            transform.Translate(_xValue, 0f, _zValue);
        }
    }
}
