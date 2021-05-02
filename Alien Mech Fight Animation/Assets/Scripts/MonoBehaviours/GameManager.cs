using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MonoBehaviours
{
    public class GameManager : UnityEngine.MonoBehaviour
    {
        public Action reloaded;
        public void ReloadScene()
        {
            if (Application.isPlaying) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            if (reloaded != null) reloaded.Invoke();
        }
    }
}