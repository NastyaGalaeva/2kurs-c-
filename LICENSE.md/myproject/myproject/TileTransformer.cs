namespace Collage
{
    using myproject;
    using System;
    using System.Drawing;



    internal class TileTransformer
    {
        private readonly IRandomGenerator randomGenerator;

        public TileTransformer()
        {
            this.randomGenerator = new RandomGenerator();
        }

        internal class TileTransformerSettings
        {
            public Percentage ScalePercent { get; set; }

            public bool RotateAndFlipRandomly { get; set; }

            public float GraphicsDpiX { get; set; }

            public float GraphicsDpiY { get; set; }
        }

        public Image Transform(Image tile, TileTransformerSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            if (tile == null)
            {
                throw new ArgumentNullException("tile");
            }

            var tileScaled = tile.Scale(settings.ScalePercent);            

            if (Math.Abs(tileScaled.HorizontalResolution - settings.GraphicsDpiX) > 0.01 ||
                Math.Abs(tileScaled.VerticalResolution - settings.GraphicsDpiY) > 0.01)
            {
                tileScaled.SetResolution(settings.GraphicsDpiX, settings.GraphicsDpiY);
            }

            return tileScaled;
        }
    }
}