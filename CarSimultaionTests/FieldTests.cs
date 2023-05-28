using CarSimulation.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimultaionTests
{
    [TestFixture]
    public class FieldTests
    {
        [Test]
        public void Constructor_DefaultValues_WidthAndHeightAreZero()
        {
            // Arrange
            Field field = new Field();

            // Assert
            Assert.AreEqual(0, field.Width);
            Assert.AreEqual(0, field.Height);
        }

        [Test]
        public void Constructor_WithValues_WidthAndHeightAreSet()
        {
            // Arrange
            int width = 5;
            int height = 3;

            // Act
            Field field = new Field(width, height);

            // Assert
            Assert.AreEqual(width, field.Width);
            Assert.AreEqual(height, field.Height);
        }

        [Test]
        public void Width_SetValue_WidthIsUpdated()
        {
            // Arrange
            Field field = new Field();
            int newWidth = 8;

            // Act
            field.Width = newWidth;

            // Assert
            Assert.AreEqual(newWidth, field.Width);
        }

        [Test]
        public void Height_SetValue_HeightIsUpdated()
        {
            // Arrange
            Field field = new Field();
            int newHeight = 6;

            // Act
            field.Height = newHeight;

            // Assert
            Assert.AreEqual(newHeight, field.Height);
        }
    }
}
