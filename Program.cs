﻿using System;

namespace graph_theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graph Theory");

            var testGraph = new Graph(5);

            testGraph.AddEdge(0,1);
            testGraph.AddEdge(0,4);
            testGraph.AddEdge(1,2);
            testGraph.AddEdge(1,3);
            testGraph.AddEdge(1,4);
            testGraph.AddEdge(2,3);
            testGraph.AddEdge(3,4);

            Console.WriteLine(testGraph.ToString());
        }
    }
}
