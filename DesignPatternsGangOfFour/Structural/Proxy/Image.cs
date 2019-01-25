using System;
using System.IO;
using DesignPatternsGangOfFour.Structural.Common;

namespace DesignPatternsGangOfFour.Structural.Proxy
{
    public class Image : IGraphic
    {
        private string fileName;

        public Image(string fileName) // loads image from a file
        {
            this.fileName = fileName.ToUpper();
        }

        public void Draw(Point at)
        {
            // some implementation
        }

        public Point GetExtent()
        {
            throw new NotImplementedException();
        }

        public void HandleMouse(Event ev)
        {
            // some implementation
        }

        public void Load(Stream from)
        {
            // some implementation
        }

        public void Save(Stream to)
        {
            // some implementation
        }
    }
}