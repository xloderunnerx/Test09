using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public class Pool : MonoBehaviour
    {
        private static Pool _instance;

        public List<Slide> _slides;
        public List<Slide> _usedSlides;

        private void Awake()
        {
            _instance = this;
        }

        public static Pool GetInstance() => _instance;

        public void ResetPool()
        {
            _slides.AddRange(_usedSlides);
            _usedSlides.Clear();
        }
    }
}