using System;
using System.Collections.Generic;
using System.Text;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Business.Interfaces
{
    public interface ICoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }
        public void StartDirection(List<int> maxCoordinate, string characterDizi);
    }
}
