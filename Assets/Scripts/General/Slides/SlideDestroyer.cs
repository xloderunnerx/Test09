using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public class SlideDestroyer : MonoBehaviour
    {
        [SerializeField] private float _destroyDistance;
        private Vector2 _startPosition;

        void Start()
        {
            _startPosition = transform.position;
        }

        void Update()
        {
            DestroySlide();
        }

        void DestroySlide()
        {
            if (_destroyDistance > Vector2.Distance(transform.position, _startPosition))
                return;

            Destroy(gameObject);
        }
    }
}