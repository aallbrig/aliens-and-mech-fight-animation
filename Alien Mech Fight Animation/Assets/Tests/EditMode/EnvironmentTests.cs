using NUnit.Framework;
using UnityEngine;

namespace Tests.EditMode
{
    public class EnvironmentTests
    {
        [Test]
        public void Environment_IsStatic()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Environment");
            var gameObject = GameObject.Instantiate(prefab);
            Assert.IsTrue(gameObject.isStatic);
        }

        [Test]
        public void Environment_HasGround()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Environment");
            var gameObject = GameObject.Instantiate(prefab);
            var ground = gameObject.transform.Find("Ground");

            Assert.NotNull(ground);
        }

        [Test]
        public void Environment_HasCity()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Environment");
            var gameObject = GameObject.Instantiate(prefab);
            var city = gameObject.transform.Find("City");

            Assert.NotNull(city);
        }
        
        [Test]
        public void Environment_HasHangers()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Environment");
            var gameObject = GameObject.Instantiate(prefab);
            var city = gameObject.transform.Find("Hangers");

            Assert.NotNull(city);
        }
    }
}