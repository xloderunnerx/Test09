using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{

    public class BackgroundColorChange : MonoBehaviour
    {

        private Camera _camera;
        [SerializeField] private float _colorChangingSpeed;

        void Start()
        {
            _camera = GetComponent<Camera>();
        }


        void Update()
        {
            ChangeColor();
        }

        void ChangeColor()
        {
            float h = 0;
            float s = 0;
            float v = 0;

            Color.RGBToHSV(_camera.backgroundColor, out h, out s, out v);
            Color newColor = Color.HSVToRGB(h + Time.deltaTime * _colorChangingSpeed, s, v);
            _camera.backgroundColor = newColor;
        }
    }
}