using System.Drawing;

namespace Generation.Painter
{
    public abstract class Paintable : IPaintable
    {
        public Color Color { get; protected set; }

        public virtual void ChangeColor(Color color)
        {
            Color = color; 
        }
    }
}