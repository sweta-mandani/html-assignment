using TestingAssignment;
using System;
using Xunit;

namespace TestingAssignment_Test
{
    public class UnitTest1
    {


        /// <summary>
        /// lowercase characters converted to uppercase.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("sahil", "SAHIL")]
        [InlineData("sWeta", "SWETA")]
        [InlineData("sWeta@", "SWETA@")]
        [InlineData("sWeta12", "SWETA12")]

        public void Test_AddUpperCase(string input, string output)
        {
            // Arrange

            // Act
            var result = input.AddUpperCase();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// uppercase characters converted to lowercase .
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("SAHIL", "sahil")]
        [InlineData("SWETA", "sweta")]
        [InlineData("SWETA@", "sweta@")]
        [InlineData("SWETA12", "sweta12")]
        public void Test_AddLowerCase(string input, string output)
        {
            //Arrange

            // Act
            var result = input.AddLowerCase();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// positive string to title case 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("tcs digital", "Tcs Digital")]
        [InlineData("tcs digital ninja", "Tcs Digital Ninja")]
        public void TaskPositive_TitleCase(string input, string output)
        {
            // Arrange

            // Act
            var result = input.TitleCase();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        ///  Negative string to title case 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("tcs digital", "TCs DiGital")]
        [InlineData("tcs digital ninja", "tcs digital Ninja")]
        public void TaskNegative_TitleCase(string input, string output)
        {
            // Arrange

            // Act
            var result = input.TitleCase();
            // Assert
            Assert.NotEqual(output, result);
        }

        /// <summary>
        /// lower case or not
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        
        [Theory]
        [InlineData("do or die", true)]
        [InlineData("SWETA", false)]

        public void Test_CheckLowerCase(string input, bool output)
        {
            // Arrange
          
            // Act
            var result = input.CheckLowerCase();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// first character have upper case and the rest lower case.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("SWETA", "SWETA")]
        [InlineData("SWETA123", "SWETA123")]
        public void Test_FirstUpperLetter(string input, string output)
        {
            // Arrange
          
            // Act
            var result = input.FirstUpperLetter();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// upper case or not
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
       
        [Theory]
        [InlineData("do or die", false)]
        [InlineData("SWETA", true)]
        [InlineData("SWETA123", true)]
        public void Test_CheckUpperCase(string input, bool output)
        {
            // Arrange
           
            // Act
            var result = input.CheckUpperCase();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// valid numeric value or not
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        
        [Theory]
        [InlineData("123@", false)]
        [InlineData("123", true)]
        [InlineData("SWETA123", false)]
        public void Test_NumberValidation(string input, bool output)
        {
            // Arrange
           
            // Act
            var result = input.NumberValidation();
            // Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// Positive result remove the last character from given the string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
       
        [Theory]
        [InlineData("sweta", "swet")]
        [InlineData("com","co")]
        public void TestPositive_LastCharacterRemove(string input, string output)
        {
            //Arrange
           
            // Act
            var result = input.LastCharacterRemove();
            //Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// negative result remove the last character from given the string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        
        [Theory]
        [InlineData("sweta", "swetaa")]
        [InlineData("com", "com")]
        public void TestNegative_LastCharacterRemove(string input, string output)
        {
            //Arrange

            // Act
            var result = input.LastCharacterRemove();
            //Assert
            Assert.NotEqual(output, result);
        }

        /// <summary>
        /// word count from an input string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("sweta", 1)]
        [InlineData("tcs digital", 2)]
        public void Test_WordCount(string input, int output)
        {
            //Arrange
         
            // Act
            var result = input.WordCount();
            //Assert
            Assert.Equal(output, result);
        }

        /// <summary>
        /// input string to integer.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>

        [Theory]
        [InlineData("123",123)]
        [InlineData("235", 235 )]
        public void Test_StringToInt(string input, int output)
        {
            // Arrange
          
            // Act
            var result = input.StringToInt();
            // Assert
            Assert.Equal(output, result);
        }
    }
}
