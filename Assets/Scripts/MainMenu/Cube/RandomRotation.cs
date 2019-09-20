using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainMenu
{
    public class RandomRotation : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _addTorqueFrequency;
        private float _addTorqueFrequencyCounter;

        void Start()
        {
            _addTorqueFrequencyCounter = 0;
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            RotateRandomly();
        }

        void RotateRandomly()
        {
            if (!AddTorqueTimer())
                return;

            _rigidbody.AddTorque(new Vector3(Random.Range(0.0f, 1.0f) * _rotationSpeed, Random.Range(0.0f, 1.0f) * _rotationSpeed, Random.Range(0.0f, 1.0f) * _rotationSpeed), ForceMode.Impulse);
        }

        private bool AddTorqueTimer()
        {
            _addTorqueFrequencyCounter -= Time.deltaTime;

            if (_addTorqueFrequencyCounter <= 0)
            {
                _addTorqueFrequencyCounter = _addTorqueFrequency;
                return true;
            }
            return false;
        }
    }
}
