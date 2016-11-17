using System.Drawing;

namespace Generation.Painter
{
    public class Painter
    {
        public void Paint(IPaintable paintable, Color color)
        {
            paintable.ChangeColor(color);
        }
    }
}