using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu.Cube
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private string _sceneName;

        void Start()
        {

        }

        void Update()
        {

        }

        void LoadScene()
        {
            SceneManager.LoadScene(_sceneName);
        }

        private void OnMouseUp()
        {
            LoadScene();
        }
    }
}
