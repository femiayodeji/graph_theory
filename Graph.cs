using System;
using System.Collections.Generic;
using System.Linq;

public interface Graph
{
    void AddEdge(int u, int v);
    string ToString();
}

public interface Search
{
    void BFS(int startNode);
}

public class Adjacency_List_Graph : Graph, Search
{
    private LinkedList<int>[] _graph;
    
    public Adjacency_List_Graph(int vertices)
    {
         _graph = new LinkedList<int>[vertices]; 
         Initialize();  
    }

    private void Initialize(){
        for (int i = 0; i < _graph.Length; i++)
            _graph[i] = new LinkedList<int>();
    }

    public void AddEdge(int u, int v)
    {
        _graph[u].AddLast(v);
        _graph[v].AddLast(u);
    }

    public override string ToString()
    {
        string output = "";
        for(int i = 0; i < _graph.Length; i++)
        {
            output += $"Vertex {i}\n Head";
            foreach (var item in _graph[i])
            {
                output += $" -> {item}";                
            }
            output += "\n";
        }
        return output;
    }

    public void BFS(int startNode)
    {
        int v = _graph.Length;
        bool[] visited = new bool[v];
        for (int i = 0; i < v; i++)
            visited[i] = false;

        LinkedList<int> queue = new LinkedList<int>();

        visited[startNode] = true;
        queue.AddLast(startNode);

        while(queue.Any())
        {
            startNode = queue.First();
            Console.Write($"{startNode} ");
            queue.RemoveFirst();

            LinkedList<int> list = _graph[startNode];

            foreach (var val in list)
            {
                if (!visited[val])
                {
                    visited[val] = true;
                    queue.AddLast(val);
                }
            }
        }
    }
}

public class Adjacency_Matrix_Graph : Graph
{
    private int[][] _graph;
    
    public Adjacency_Matrix_Graph(int vertices)
    {
        _graph = new int[vertices][];
         Initialize();  
    }

    private void Initialize(){
        for (int i = 0; i < _graph.Length; i++)
            _graph[i] = new int[_graph.Length];
    }

    public void AddEdge(int u, int v)
    {
        _graph[u][v] = 1;
        _graph[v][u] = 1;
    }

    public override string ToString()
    {
        string output = "";
        for(int i = 0; i < _graph.Length; i++)
        {
            output += $"Vertex {i}\n Head";
            foreach (var item in _graph[i])
            {
                output += $" | {item}";                
            }            
            output += "\n";
        }
        return output;
    }
}