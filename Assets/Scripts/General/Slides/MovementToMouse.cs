using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public class MovementToMouse : MonoBehaviour
    {
        [SerializeField] private float _movementSpeed;
        [SerializeField] private Vector3 _offset;

        void Start()
        {

        }

        void Update()
        {
           
        }

        public void Movement()
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, Utility.GetMouseWorldCoordinates().x + _offset.x, Time.deltaTime * _movementSpeed), transform.position.y, transform.position.z);
        }

        public void CalculateOffset()
        {
            _offset = transform.position - Utility.GetMouseWorldCoordinates();
        }

        private void OnMouseDown()
        {
            CalculateOffset();
        }

        private void OnMouseDrag()
        {
            Movement();
        }
    }
}