using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Interfaces
{
    public interface IRotate
    {
        public void Turn90Left();
        public void Turn90Right();
        public void SameDirection();
    }
}
