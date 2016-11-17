using System.Drawing;
using NUnit.Framework;

namespace Generation.Painter.Tests
{
    [TestFixture]
    public class CarTests
    {
        private Car _car;

        [SetUp]
        public void SetUp()
        {
            _car = new Car(CarType.Sedan);
        }

        [Test]
        public void Type_should_be_set()
        {
            Assert.AreEqual(CarType.Sedan, _car.Type);
        }

        [Test]
        public void Should_have_default_color_of_gray()
        {
            Assert.AreEqual(Color.Gray, _car.Color);
        }

        [Test]
        public void ChangeColor_should_set_the_color_to_selected_color()
        {
            _car.ChangeColor(Color.Salmon);

            Assert.AreEqual(Color.Salmon, _car.Color);
        }
    }
}