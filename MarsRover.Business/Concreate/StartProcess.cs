using MarsRover.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Business.Concreate
{
    public class StartProcess : ICoordinate, IRotate
    {
        public StartProcess()
        {
            X = Y = 0;
            Direction = Directions.N;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public void StartDirection(List<int> maxCoordinate, string characterDizi)
        {
            foreach (var move in characterDizi)
            {
                switch (move)
                {
                    case 'M':
                        this.SameDirection();
                        break;
                    case 'L':
                        this.Turn90Left();
                        break;
                    case 'R':
                        this.Turn90Right();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (this.X < 0 || this.X > maxCoordinate[0] || this.Y < 0 || this.Y > maxCoordinate[1])
                {
                    throw new Exception($"out of coordinate (0 , 0) and ({maxCoordinate[0]} , {maxCoordinate[1]})");
                }
            }
        }
        public void SameDirection()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }
        public void Turn90Left()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        public void Turn90Right()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
    }
}
