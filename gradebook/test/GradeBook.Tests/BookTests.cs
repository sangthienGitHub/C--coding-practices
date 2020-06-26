using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.2);
            book.AddGrade(90.2);
            book.AddGrade(75.7);


            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85, result.Average, 1);
            Assert.Equal(90.2, result.High, 1);
            Assert.Equal(75.7, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }
    }
}
