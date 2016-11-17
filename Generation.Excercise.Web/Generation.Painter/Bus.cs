using System.Drawing;

namespace Generation.Painter
{
    public class Bus : Paintable
    {
        public int NumberOfSeats { get; private set; }
       
        public Bus(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
            Color = Color.Gray;
        }

        public override void ChangeColor(Color color)
        {
            if (color == Color.Salmon)
            {
                Color = Color.Yellow;
            }
            else
            {
                base.ChangeColor(color);
            }
        }
    }
}