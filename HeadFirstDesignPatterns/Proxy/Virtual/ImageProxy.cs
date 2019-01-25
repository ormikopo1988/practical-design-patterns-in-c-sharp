using System;

namespace HeadFirstDesignPatterns.Proxy.Virtual
{
    public class ImageProxy : Icon
    {
        private Image imageIcon = null; // this is the real "expensive" object we proxy to
        private string imageUrl = null;
        private bool retrieving = false;

        public ImageProxy(string imageUrl)
        {
            this.imageUrl = imageUrl;
        }

        public int GetIconHeight()
        {
            if (this.imageIcon != null)
            {
                return this.imageIcon.GetIconHeight();
            }
            else
            {
                Console.Write("Default height returned from proxy: ");
                return 600;
            }
        }

        public int GetIconWidth()
        {
            if (this.imageIcon != null)
            {
                return this.imageIcon.GetIconWidth();
            }
            else
            {
                Console.Write("Default width returned from proxy: ");
                return 800;
            }
        }

        public void PaintIcon()
        {
            if (this.imageIcon != null)
            {
                this.imageIcon.PaintIcon();
            }
            else
            {
                Console.WriteLine("Loading CD cover, please wait...");

                if(!retrieving)
                {
                    retrieving = true;

                    // Simulate fetching image from the web
                    this.imageIcon = new Image(this.imageUrl, "CD Cover");

                    this.imageIcon.PaintIcon();
                }
            }
        }
    }
}