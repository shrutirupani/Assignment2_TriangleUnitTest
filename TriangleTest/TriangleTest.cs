using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2_8040;
using NUnit.Framework;


namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void Analyze_Inputside1Equals2_side2Equals200_side3Equals2_ReturnsNotValidTriangle()
        {
            //Arrange
            int side1 = 2;
            int side2 = 200;
            int side3 = 2; 

            //Act
            string expectedResult = "It is not valid Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals1_side2Equals2_side3Equals3_ReturnsNotValidTriangle()
        {
            //Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 3;

            //Act
            string expectedResult = "It is not valid Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals6_side2Equals6_side3Equals6_ReturnsEquilateralTriangle()
        {
            //Arrange
            int side1 = 6;
            int side2 = 6;
            int side3 = 6;

            //Act
            string expectedResult = "It is Equilateral Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals12_side2Equals12_side3Equals12_ReturnsEquilateralTriangle()
        {
            //Arrange
            int side1 = 12;
            int side2 = 12;
            int side3 = 12;

            //Act
            string expectedResult = "It is Equilateral Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals3_side2Equals3_side3Equals5_ReturnsIsoseclesTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 5;

            //Act
            string expectedResult = "It is Isosceles Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals11_side2Equals11_side3Equals15_ReturnsIsoseclesTriangle()
        {
            //Arrange
            int side1 = 11;
            int side2 = 11;
            int side3 = 15;

            //Act
            string expectedResult = "It is Isosceles Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals3_side2Equals4_side3Equals5_ReturnsScaleneTriangle()
        {
            //Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            //Act
            string expectedResult = "It is Scalene Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Inputside1Equals20_side2Equals21_side3Equals22_ReturnsScaleneTriangle()
        {
            //Arrange
            int side1 = 20;
            int side2 = 21;
            int side3 = 22;

            //Act
            string expectedResult = "It is Scalene Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
