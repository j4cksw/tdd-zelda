using NUnit.Framework;
using UnityEngine.UI;
using UnityEngine;

namespace Tests
{
    public class HeartTests
    {
        Image heartImage;
        Heart heart;

        [SetUp]
        public void SetUp(){
            var heartImage = new GameObject().AddComponent<Image>();
            heartImage.fillAmount = 0;
            var heart = new Heart(heartImage);
        }

        [Test]
        public void _Given_Replenish_0_Should_Set_FillAmount_of_image_to_0()
        {
            heart.Replenish(0);
            
            Assert.AreEqual(0, heartImage.fillAmount);
        }

        [Test]
        public void _Given_Replenish_1_Should_Set_FillAmount_of_image_to_25()
        {
            heart.Replenish(1);
            
            Assert.AreEqual(0.25f, heartImage.fillAmount);
        }

        [Test]
        public void _Given_Replenish_1_Twice_Should_Set_FillAmount_of_image_to_50()
        {
            heart.Replenish(1);
            heart.Replenish(1);

            Assert.AreEqual(0.5f, heartImage.fillAmount);
        }
    }
}
