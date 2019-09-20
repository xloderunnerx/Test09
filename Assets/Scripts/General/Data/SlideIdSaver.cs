using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.Slides
{
    public static class SlideIdSaver
    {
        public static void Save()
        {
            PlayerPrefs.SetInt("SlideId", Instantiator.GetInstance()._currentSlideId);
        }
    }
}