using System;
using UnityEngine.UI;

namespace Tests
{
    internal class Heart
    {
        private Image heartImage;

        public Heart(Image heartImage)
        {
            this.heartImage = heartImage;
        }

        public void Replenish(int numberOfHeartPieces)
        {
            heartImage.fillAmount += numberOfHeartPieces*0.25f;
        }
    }
}