using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public class MovementToStartPosition : MonoBehaviour
    {
        private Vector2 _startPosition;
        [SerializeField] private float _movementSpeed;

        void Start()
        {
            _startPosition = transform.position;
        }


        void Update()
        {
            Movement();
        }

        void Movement()
        {
            if (Input.GetKey(KeyCode.Mouse0))
                return;

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, _startPosition.x, Time.deltaTime * _movementSpeed), transform.position.y, transform.position.z);
        }
    }
}