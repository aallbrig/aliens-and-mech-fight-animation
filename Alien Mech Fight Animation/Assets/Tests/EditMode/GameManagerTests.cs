using MonoBehaviours;
using NUnit.Framework;
using UnityEngine;

namespace Tests.EditMode
{
    public class GameManagerTests
    {
        [Test]
        public void GameManager_CanReloadScene()
        {
            var success = false;
            var gameManager = new GameObject().AddComponent<GameManager>();
            gameManager.reloaded += () => success = true;

            gameManager.ReloadScene();

            Assert.IsTrue(success);
        }

        [Test]
        public void GameManager_Prefab_ContainsGameManagerMonobehaviour()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/GameManager");
            var gameObject = GameObject.Instantiate(prefab);
            var script = gameObject.GetComponent<GameManager>();
            Assert.NotNull(script);
        }
    }
}
