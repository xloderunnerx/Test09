using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using General.Slides;

namespace General.Slides
{
    public class MovementAway : MonoBehaviour
    {
        [SerializeField] private float _awayMovementDistance;
        private Vector2 _starPosition;
        private float _movementDirection;
        [SerializeField] private float _movementSpeed;

        void Start()
        {
            _starPosition = transform.position;
        }

        void Update()
        {
            Movement();
        }

        void Movement()
        {
            if (_awayMovementDistance > Vector2.Distance(transform.position, _starPosition))
                return;

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x + _movementDirection, Time.deltaTime * _movementSpeed), transform.position.y, transform.position.z);
        }

        void CalculateDirection()
        {
            if (transform.position.x < _starPosition.x)
                _movementDirection = -1.0f;
            else if (transform.position.x > _starPosition.x)
                _movementDirection = 1.0f;
        }

        void ResetDirection()
        {
            _movementDirection = 0.0f;
        }

        void TurnOffMovementToStartPosition()
        {
            GetComponent<MovementToStartPosition>().enabled = false;
        }

        void TurnOffMovementToMouse()
        {
            GetComponent<MovementToMouse>().enabled = false;
        }

        void InstantiateNewSlide()
        {
            Instantiator.GetInstance().InstantiateSlide();
        }

        void SetSlideSwipe()
        {
            if (_movementDirection < 0)
                SlideSwipes.GetInstance().LeftSwipes++;
            else if (_movementDirection > 0)
                SlideSwipes.GetInstance().RightSwipes++;
        }

        private void OnMouseDown()
        {
            ResetDirection();
        }

        private void OnMouseUp()
        {
            if (_awayMovementDistance > Vector2.Distance(transform.position, _starPosition))
                return;

            CalculateDirection();

            TurnOffMovementToMouse();
            TurnOffMovementToStartPosition();
            InstantiateNewSlide();
            SetSlideSwipe();
        }
    }
}