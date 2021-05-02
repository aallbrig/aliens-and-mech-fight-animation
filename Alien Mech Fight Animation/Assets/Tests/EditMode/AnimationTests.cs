using NUnit.Framework;
using UnityEngine;
using UnityEngine.Playables;

namespace Tests.EditMode
{
    public class AnimationTests
    {
        [Test]
        public void Prefab_PlayableDirector_HasPlayableBound()
        {
            var prefab = Resources.Load<GameObject>("Prefabs/TheAnimation");
            var gameObject = GameObject.Instantiate(prefab);
            var playableDirector = gameObject.GetComponent<PlayableDirector>();

            Assert.NotNull(playableDirector.playableAsset);
        }
    }
}