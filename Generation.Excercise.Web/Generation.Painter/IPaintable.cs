using System.Drawing;

namespace Generation.Painter
{
    public interface IPaintable
    {
        Color Color { get; }
        void ChangeColor(Color color);
    }
}