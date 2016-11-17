using System.Drawing;
using NUnit.Framework;

namespace Generation.Painter.Tests
{
    [TestFixture]
    public class BusTests
    {
        private Bus _bus;

        [SetUp]
        public void SetUp()
        {
            _bus = new Bus(40);
        }

        [Test]
        public void Should_have_default_color_of_gray()
        {
            Assert.AreEqual(Color.Gray, _bus.Color);
        }

        [Test]
        public void Should_have_number_of_seats_set()
        {
            Assert.AreEqual(40, _bus.NumberOfSeats);
        }

        [Test]
        public void ChangeColor_should_set_the_color_to_selected_color()
        {
            _bus.ChangeColor(Color.HotPink);

            Assert.AreEqual(Color.HotPink, _bus.Color);
        }
    }
}
