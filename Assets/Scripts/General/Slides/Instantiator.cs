using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace General.Slides
{
    public class Instantiator : MonoBehaviour
    {
        private static Instantiator _instance;

        [SerializeField] private GameObject _slideGameObject;
        [SerializeField] private Text _slideText;
        public int _currentSlideId;

        [SerializeField] private Vector2 _slideSpawnPoint;

        private void Awake()
        {
            _instance = this;
            SlideIdLoader.Load();
        }

        public static Instantiator GetInstance() => _instance;

        void Start()
        {
            if(_currentSlideId != 0)
            {
                InstantiateSlide(_currentSlideId);
                return;
            }
            InstantiateSlide();
        }

        void Update()
        {

        }

        public void InstantiateSlide()
        {
            if (Pool.GetInstance()._slides.Count == 0)
                Pool.GetInstance().ResetPool();

            Slide slide = Pool.GetInstance()._slides[Random.Range(0, Pool.GetInstance()._slides.Count - 1)];
            Pool.GetInstance()._usedSlides.Add(slide);
            Pool.GetInstance()._slides.Remove(slide);

            GameObject slideGameObject = Instantiate(_slideGameObject, _slideSpawnPoint, Quaternion.identity);
            slideGameObject.GetComponent<SpriteRenderer>().sprite = slide._picture;
            _slideText.text = slide._text;
            _currentSlideId = slide._id;
            SlideIdSaver.Save();
        }

        public void InstantiateSlide(int id)
        {
            Slide slide = Pool.GetInstance()._slides.Where(s => s._id == id).ToList()[0];

            Pool.GetInstance()._usedSlides.Add(slide);
            Pool.GetInstance()._slides.Remove(slide);

            GameObject slideGameObject = Instantiate(_slideGameObject, _slideSpawnPoint, Quaternion.identity);
            slideGameObject.GetComponent<SpriteRenderer>().sprite = slide._picture;
            _slideText.text = slide._text;
        }

    }
}