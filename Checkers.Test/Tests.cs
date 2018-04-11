using System;
using NUnit.Framework;
using System.Linq;
namespace Checkers.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ABoardHas12BlackAnd12WhitePieces()
        {
             // All tests use Arrange-Act-Assert
            Board b = new Board(); // arrange the enviroment
            int blackCount = b.Pieces(Color.Black).Count(); // act
            int whiteCount = b.Pieces(Color.White).Count(); // act
            Assert.That(blackCount == 12); //assert
            Assert.That(whiteCount == 12); // assert
        }
    }
}
