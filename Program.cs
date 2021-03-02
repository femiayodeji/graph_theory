using System;

namespace graph_theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graph Theory");
            Console.WriteLine("\n____________________\n");

            Console.WriteLine("Adjacency List Representation");
            Graph testGraph = new Adjacency_List_Graph(5);

            testGraph.AddEdge(0,1);
            testGraph.AddEdge(0,4);
            testGraph.AddEdge(1,2);
            testGraph.AddEdge(1,3);
            testGraph.AddEdge(1,4);
            testGraph.AddEdge(2,3);
            testGraph.AddEdge(3,4);

            Console.WriteLine(testGraph.ToString());

            Console.WriteLine("Adjacency Matrix Representation");
            testGraph = new Adjacency_Matrix_Graph(5);

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
