using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public static class SlideSwipesLoader
    {
        public static void Load()
        {
            if (PlayerPrefs.HasKey("Left"))
                SlideSwipes.GetInstance().LeftSwipes = PlayerPrefs.GetInt("Left");

            if (PlayerPrefs.HasKey("Right"))
                SlideSwipes.GetInstance().RightSwipes = PlayerPrefs.GetInt("Right");
        }
    }
}