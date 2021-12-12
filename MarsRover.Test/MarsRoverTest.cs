using MarsRover.Business.Concreate;
using MarsRover.Business.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void Test_LMLMLMLMM()
        {
            ICoordinate start = new StartProcess()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };
            var maxCoortinate = new List<int> { 5, 5 };
            var characterDizi = "LMLMLMLMM";
            start.StartDirection(maxCoortinate, characterDizi);
            var result= $"{start.X} {start.Y} {start.Direction.ToString()}";
            var controlCoordinate = "1 3 N";
            Assert.AreEqual(result, controlCoordinate);

        }
        [TestMethod]
        public void Test_MMRMMRMRRM()
        {
            ICoordinate start = new StartProcess()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };
            var maxCoortinate = new List<int> { 5, 5 };
            var characterDizi = "MMRMMRMRRM";
            start.StartDirection(maxCoortinate, characterDizi);
            var result = $"{start.X} {start.Y} {start.Direction.ToString()}";
            var controlCoordinate = "5 1 E";
            Assert.AreEqual(result, controlCoordinate);

        }
    }
}
