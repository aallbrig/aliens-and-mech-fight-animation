using Cinemachine;
using NUnit.Framework;
using UnityEngine;

namespace Tests.EditMode
{
    public class CameraTests
    {
        [Test]
        public void FirstCamera_Exists()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/Virtual Cameras");
            var gameObject = GameObject.Instantiate(prefab);

            var firstCamera = gameObject.transform.Find("First Camera");
            Assert.NotNull(firstCamera);
            Assert.NotNull(firstCamera.gameObject.GetComponent<CinemachineVirtualCamera>());
        }
    }
}