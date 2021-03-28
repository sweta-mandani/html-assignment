using TestingAssignment;
using System;
using Xunit;

namespace TestingAssignment_Test
{
    public class UnitTest1
    {
<<<<<<< HEAD
        //1
=======

        // lowercase characters converted to uppercase.
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_AddUpperCase()
        {
            //Arrange
            var input = "sahil";
            var expectedValue = "SAHIL";
            // Act
<<<<<<< HEAD
            var result = input.AddUpperCase();
=======
            var result = AssignmentBLL.AddUpperCase(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD
        //2
=======
        //uppercase characters converted to     lowercase and vice versa.

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_AddLowerCase()
        {
            //Arrange
            var input = "SAHIL";
            var expectedValue = "sahil";
            // Act
<<<<<<< HEAD
            var result = input.AddLowerCase();
=======
            var result = AssignmentBLL.AddLowerCase(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD
        //3
=======
        //string to title case 

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Task_TitleCase()
        {
            //Arrange
<<<<<<< HEAD
            var input = "tcs digital";
            var expectedString = "Tcs Digital";

            //Act
            var result = input.TitleCase();
=======
            var str = "tcs digital";
            var expectedString = "Tcs Digital";

            //Act
            var result = AssignmentBLL.TitleCase(str);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812

            //Assert
            Assert.Equal(expectedString, result);
        }

<<<<<<< HEAD
        //4

=======
        //lower case or not
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_CheckLowerCase()
        {
            //Arrange
            var input = "do or die";
            var expectedValue = true;
            // Act
<<<<<<< HEAD
            var result = input.CheckLowerCase();
=======
            var result = AssignmentBLL.CheckLowerCase(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }


<<<<<<< HEAD
        //5
=======
        //first character have upper case and the rest lower case.
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_FirstUpperLetter()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "Sweta";
            // Act
<<<<<<< HEAD
            var result = input.FirstUpperLetter();
=======
            var result = AssignmentBLL.FirstUpperLetter(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD
        //6
=======
        //upper case or not

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_NumberValidation()
        {
            //Arrange
            var input = "123";
            var expectedValue = true;
            // Act
<<<<<<< HEAD
            var result = input.NumberValidation();
=======
            var result = AssignmentBLL.NumberValidation(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD
        //7
=======
        //valid numeric value or not.

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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

<<<<<<< HEAD
        //8
=======
        //remove the last character from given the string

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_LastCharacterRemove()
        {
            //Arrange
            var input = "sweta";
            var expectedValue = "swet";
            // Act
<<<<<<< HEAD
            var result = input.LastCharacterRemove();
=======
            var result = AssignmentBLL.LastCharacterRemove(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD

        //9
=======
        //    word count from an input string.
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        [Fact]
        public void Test_WordCount()
        {

            //Arrange
            var input = "sweta";
            var expectedValue = 1;
            // Act
<<<<<<< HEAD
            var result = input.WordCount();
=======
            var result = AssignmentBLL.WordCount(input);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            //Assert
            Assert.Equal(expectedValue, result);
        }

<<<<<<< HEAD

        //10
=======
        // input string to integer.
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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
<<<<<<< HEAD
}
=======
}

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
