using TestingAssignment;
using System;
using Xunit;

namespace TestingAssignment_Test
{
    public class UnitTest1
    {
        //1
        [Fact]
        public void Test_AddUpperCase()
        {
            //Arrange
            var input = "sahil";
            var expectedValue = "SAHIL";
            // Act
            var result = input.AddUpperCase();
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //2
        [Fact]
        public void Test_AddLowerCase()
        {
            //Arrange
            var input = "SAHIL";
            var expectedValue = "sahil";
            // Act
            var result = input.AddLowerCase();
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //3
        [Fact]
        public void Task_TitleCase()
        {
            //Arrange
            var input = "tcs digital";
            var expectedString = "Tcs Digital";

            //Act
            var result = input.TitleCase();

            //Assert
            Assert.Equal(expectedString, result);
        }

        //4

        [Fact]
        public void Test_CheckLowerCase()
        {
            //Arrange
            var input = "do or die";
            var expectedValue = true;
            // Act
            var result = input.CheckLowerCase();
            //Assert
            Assert.Equal(expectedValue, result);
        }


        //5
        [Fact]
        public void Test_FirstUpperLetter()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "Sweta";
            // Act
            var result = input.FirstUpperLetter();
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //6
        [Fact]
        public void Test_NumberValidation()
        {
            //Arrange
            var input = "123";
            var expectedValue = true;
            // Act
            var result = input.NumberValidation();
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //7
        [Fact]
        public void Test_CheckUpperCase()
        {
            //Arrange
            var input = "SWETA";
            var expectedValue = true;
            // Act
            var result = input.CheckUpperCase();
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //8
        [Fact]
        public void Test_LastCharacterRemove()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "swet";
            // Act
            var result = input.LastCharacterRemove();
            //Assert
            Assert.Equal(expectedValue, result);
        }


        //9
        [Fact]
        public void Test_WordCount()
        {

            //Arrange
            var input = "sweta";
            var expectedValue = 1;
            // Act
            var result = input.WordCount();
            //Assert
            Assert.Equal(expectedValue, result);
        }


        //10
        [Fact]
        public void Test_StringToInt()
        {
            //Arrange
            var input = "123";
            var expectedValue = 123;
            // Act
            var result = input.StringToInt();
            //Assert
            Assert.Equal(expectedValue, result);
        }


    }
}