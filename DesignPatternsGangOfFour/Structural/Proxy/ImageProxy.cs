using System.IO;
using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Proxy
{
    public class ImageProxy : IGraphic
    {
        private string fileName;
        private Image image;
        private Point extent;

        public ImageProxy(string fileName)
        {
            this.fileName = fileName.ToUpper();
            this.image = null;
            this.extent = new Point(); // don't know extent yet
        }

        public void Draw(Point at)
        {
            this.GetImage().Draw(at);
        }

        public Point GetExtent()
        {
            if (extent.X == 0.0 && extent.Y == 0.0)
            {
                extent = GetImage().GetExtent();
            }

            return extent;
        }

        public void HandleMouse(Event ev)
        {
            this.GetImage().HandleMouse(ev);
        }

        public void Load(Stream from)
        {
            // Load retrieves the cached image extent and the 
            // image file name from the stream and initializes the corresponding members
        }

        public void Save(Stream to)
        {
            // The Save operation saves the cached image extent and the image file name
            // to a stream
        }

        protected Image GetImage()
        {
            if (image == null)
            {
                image = new Image(fileName);
            }

            return image;
        }
    }
}