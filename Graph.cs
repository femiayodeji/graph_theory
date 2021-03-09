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
    void DFS(int startNode);
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

            LinkedList<int> nodes = _graph[startNode];

            foreach (var val in nodes)
            {
                if (!visited[val])
                {
                    visited[val] = true;
                    queue.AddLast(val);
                }
            }
        }
    }

    public void DFS(int startNode)
    {
        bool[] visited = new bool[_graph.Length];
        DepthSearch(startNode, visited);
    }
    
    public void DepthSearch(int node, bool[] visited)
    {
        visited[node] = true;
        Console.Write($"{node} ");

        LinkedList<int> nodes = _graph[node];
        foreach( var neighbour in nodes)
        {
            if (!visited[neighbour])
                DepthSearch(neighbour, visited);
        }
    }

    public bool HasCycle()
    {
        bool[] visited = new bool[_graph.Length];
        bool[] memo = new bool[_graph.Length];

        for (int i = 0; i < _graph.Length; i++)
        {
            if (isCyclic(i, visited, memo))
                return true;
        }
        return false;
    }

    public bool isCyclic(int node, bool[] visited, bool[] memo)
    {
        if (memo[node])
            return true;
        
        if (visited[node])
            return true;

        visited[node] = true;
        memo[node] = true;

        LinkedList<int> childrenNodes = _graph[node];

        foreach(int childNode in childrenNodes)
        {
            if (isCyclic(childNode, visited, memo))
                return true;
        }
        memo[node] = false;
        return false;
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