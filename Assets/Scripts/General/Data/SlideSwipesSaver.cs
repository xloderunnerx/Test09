using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public static class SlideSwipesSaver
    {
        public static void SaveLeft()
        {
            PlayerPrefs.SetInt("Left", SlideSwipes.GetInstance().LeftSwipes);
        }

        public static void SaveRight()
        {
            PlayerPrefs.SetInt("Right", SlideSwipes.GetInstance().RightSwipes);
        }
    }
}
