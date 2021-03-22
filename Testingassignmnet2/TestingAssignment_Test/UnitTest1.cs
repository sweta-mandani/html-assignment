using TestingAssignment;
using System;
using Xunit;

namespace TestingAssignment_Test
{
    public class UnitTest1
    {

        // lowercase characters converted to uppercase.
        [Fact]
        public void Test_AddUpperCase()
        {
            //Arrange
            var input = "sahil";
            var expectedValue = "SAHIL";
            // Act
            var result = AssignmentBLL.AddUpperCase(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //uppercase characters converted to     lowercase and vice versa.

        [Fact]
        public void Test_AddLowerCase()
        {
            //Arrange
            var input = "SAHIL";
            var expectedValue = "sahil";
            // Act
            var result = AssignmentBLL.AddLowerCase(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //string to title case 

        [Fact]
        public void Task_TitleCase()
        {
            //Arrange
            var str = "tcs digital";
            var expectedString = "Tcs Digital";

            //Act
            var result = AssignmentBLL.TitleCase(str);

            //Assert
            Assert.Equal(expectedString, result);
        }

        //lower case or not
        [Fact]
        public void Test_CheckLowerCase()
        {
            //Arrange
            var input = "do or die";
            var expectedValue = true;
            // Act
            var result = AssignmentBLL.CheckLowerCase(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }


        //first character have upper case and the rest lower case.
        [Fact]
        public void Test_FirstUpperLetter()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "Sweta";
            // Act
            var result = AssignmentBLL.FirstUpperLetter(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //upper case or not

        [Fact]
        public void Test_NumberValidation()
        {
            //Arrange
            var input = "123";
            var expectedValue = true;
            // Act
            var result = AssignmentBLL.NumberValidation(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //valid numeric value or not.

        [Fact]
        public void Test_CheckUpperCase()
        {
            //Arrange
            var input = "SWETA";
            var expectedValue = true;
            // Act
            var result = AssignmentBLL.CheckUpperCase(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //remove the last character from given the string

        [Fact]
        public void Test_LastCharacterRemove()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "swet";
            // Act
            var result = AssignmentBLL.LastCharacterRemove(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        //    word count from an input string.
        [Fact]
        public void Test_WordCount()
        {

            //Arrange
            var input = "sweta";
            var expectedValue = 1;
            // Act
            var result = AssignmentBLL.WordCount(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }

        // input string to integer.
        [Fact]
        public void Test_StringToInt()
        {
            //Arrange
            var input = "123";
            var expectedValue = 123;
            // Act
            var result = AssignmentBLL.StringToInt(input);
            //Assert
            Assert.Equal(expectedValue, result);
        }


    }
}

