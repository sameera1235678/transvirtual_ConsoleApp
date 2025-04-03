using System;
using System.Collections.Generic;
using DijkstraLib.Algorithm;
using DijkstraLib.Data;
using DijkstraLib.Models;

namespace DijkstraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shortes Route Optimizer");
            Console.WriteLine("==================================================");

            try
            {
                List<Node> graph = Graph.CreateSampleGraph();
                PathFinder pathFinder = new PathFinder();

                Console.WriteLine("\nAvailble Nodes:");

                foreach (Node node in graph)
                {
                    Console.WriteLine($"{node._name}");
                }

                Console.WriteLine("\n");

                //Get user input
                Console.WriteLine("Enter From node:");
                string fromNode=Console.ReadLine().Trim().ToUpper();

                Console.WriteLine("Enter To node:");
                string toNode = Console.ReadLine().Trim().ToUpper();

                //Calculate shortest path
                var result = pathFinder.ShotestPath(fromNode,toNode,graph);

                //Display result
                Console.WriteLine("\nResult:");
                Console.WriteLine($"Path:{result.GetPath()}");
                Console.WriteLine($"Total Distance:{result._distance} ");v

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError:{ex.Message}"); 
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        } 
    }
}
