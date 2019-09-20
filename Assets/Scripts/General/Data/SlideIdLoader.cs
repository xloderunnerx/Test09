using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public static class SlideIdLoader
    {
        public static void Load()
        {
            if (!PlayerPrefs.HasKey("SlideId"))
                return;

            Instantiator.GetInstance()._currentSlideId = PlayerPrefs.GetInt("SlideId");
        }
    }
}