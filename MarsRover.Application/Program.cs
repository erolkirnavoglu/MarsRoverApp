using MarsRover.Business.Concreate;
using MarsRover.Business.Interfaces;
using System;
using System.Linq;
using static MarsRover.Business.Enum.Enums;

namespace MarsRover.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the maximum coordinates that can be entered");
            var maxCoordinate = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Please, enter the starting coordinate");
            var startCoordinate = Console.ReadLine().Split(' ');
            Console.WriteLine("Please, enter letter string");
            var characterDizi = Console.ReadLine().ToUpper();


            try
            {
                ICoordinate start = new StartProcess()
                {
                    X = int.Parse(startCoordinate[0]),
                    Y = int.Parse(startCoordinate[1]),
                    Direction = (Directions)Enum.Parse(typeof(Directions), startCoordinate[2].ToUpper())
                };
                start.StartDirection(maxCoordinate, characterDizi);
                Console.WriteLine($"------------------");
                Console.WriteLine($"Result : {start.X} {start.Y} {start.Direction.ToString()}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
