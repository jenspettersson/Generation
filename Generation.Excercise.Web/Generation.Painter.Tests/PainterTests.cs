using System.Drawing;
using NUnit.Framework;

namespace Generation.Painter.Tests
{
    [TestFixture]
    public class PainterTests
    {
        [Test]
        public void Should_paint_car_to_given_color()
        {
            var car = new Car(CarType.Sedan);
            var painter = new Painter();
            painter.Paint(car, Color.HotPink);

            Assert.AreEqual(Color.HotPink, car.Color);
        }

        [Test]
        public void Should_paint_bus_to_given_color()
        {
            var bus = new Bus(40);
            var painter = new Painter();
            painter.Paint(bus, Color.HotPink);

            Assert.AreEqual(Color.HotPink, bus.Color);
        }
    }
}