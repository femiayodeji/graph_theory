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
            Adjacency_List_Graph testListGraph = new Adjacency_List_Graph(5);

            testListGraph.AddEdge(0,1);
            testListGraph.AddEdge(0,4);
            testListGraph.AddEdge(1,2);
            testListGraph.AddEdge(1,3);
            testListGraph.AddEdge(1,4);
            testListGraph.AddEdge(2,3);
            testListGraph.AddEdge(3,4);

            Console.WriteLine(testListGraph.ToString());

            Console.WriteLine("Adjacency Matrix Representation");
            Adjacency_Matrix_Graph testMatrixGraph = new Adjacency_Matrix_Graph(5);

            testMatrixGraph.AddEdge(0,1);
            testMatrixGraph.AddEdge(0,4);
            testMatrixGraph.AddEdge(1,2);
            testMatrixGraph.AddEdge(1,3);
            testMatrixGraph.AddEdge(1,4);
            testMatrixGraph.AddEdge(2,3);
            testMatrixGraph.AddEdge(3,4);

            Console.WriteLine(testMatrixGraph.ToString());

            Console.Write("\nBreadth First Search => ");
            testListGraph.BFS(2);

            Console.Write("\nDepth First Search => ");
            testListGraph.DFS(2);

        }
    }
}
