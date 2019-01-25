using DesignPatternsGangOfFour.Structural.Common;
using System.IO;

namespace DesignPatternsGangOfFour.Structural.Proxy
{
    public interface IGraphic
    {
        void Draw(Point at);

        void HandleMouse(Event ev);

        Point GetExtent();

        void Load(Stream from);

        void Save(Stream to);
    }
}