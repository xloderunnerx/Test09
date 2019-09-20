using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace General.Slides
{
    public class SlideSwipes : MonoBehaviour
    {
        private static SlideSwipes _instance;

        [SerializeField] private Text _leftSwipesText;
        [SerializeField] private Text _rightSwipesText;

        private int _leftSwipes;

        public int LeftSwipes
        {
            set
            {
                _leftSwipes = value;
                _leftSwipesText.text = "LEFT: " + _leftSwipes.ToString();
                SlideSwipesSaver.SaveLeft();
            }
            get { return _leftSwipes; }
        }

        private int _rightSwipes;

        public int RightSwipes
        {
            set
            {
                _rightSwipes = value;
                _rightSwipesText.text = "RIGHT: " + _rightSwipes.ToString();
                SlideSwipesSaver.SaveRight();
            }
            get { return _rightSwipes; }
        }

        private void Awake()
        {
            _instance = this;
            SlideSwipesLoader.Load();
        }

        public static SlideSwipes GetInstance() => _instance;
    }
}