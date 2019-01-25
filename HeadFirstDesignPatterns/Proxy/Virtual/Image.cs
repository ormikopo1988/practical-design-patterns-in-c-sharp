using System;

namespace HeadFirstDesignPatterns.Proxy.Virtual
{
    public class Image : Icon
    {
        private string url;
        private string name;

        public Image(string url, string name)
        {
            this.url = url;
            this.name = name;
        }

        public int GetIconHeight()
        {
            // Some height from the image that we got from the web
            Console.Write("Actual height of image returned from the web: ");
            return 100;
        }

        public int GetIconWidth()
        {
            // Some height from the image that we got from the web
            Console.Write("Actual width of image returned from the web: ");
            return 100;
        }

        public void PaintIcon()
        {
            Console.WriteLine($"Paint the real 'expensive' icon named {this.name} fetched from the url: {this.url}.");
        }
    }
}