using System.Drawing;

namespace Generation.Painter
{
    public class Car : Paintable
    {
        public CarType Type { get; }
       
        public Car(CarType type)
        {
            Type = type;
            Color = Color.Gray;
        }
    }

    public enum CarType
    {
        Sedan,
        Combi
    }
}
