using HeadFirstDesignPatterns.Proxy.Virtual;
using System;

namespace DesignPatternsConsoleClient.HeadFirstDesignPatterns.Proxy.Virtual
{
    public class ImageProxySimulator
    {
        public static void Start()
        {
            // set up frame and menus
            Icon icon = new ImageProxy("http://some-url.com/123.png");

            Console.WriteLine($"Image icon width: {icon.GetIconWidth()}px");
            Console.WriteLine($"Image icon height: {icon.GetIconHeight()}px");

            icon.PaintIcon();

            Console.WriteLine($"Image icon width: {icon.GetIconWidth()}px");
            Console.WriteLine($"Image icon height: {icon.GetIconHeight()}px");

            icon.PaintIcon();
        }
    }
}